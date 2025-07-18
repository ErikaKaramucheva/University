from django.shortcuts import render, redirect
from django.http import HttpResponse, HttpResponseRedirect
from django.contrib import messages
from django.urls import reverse
import datetime

from student_management_app.models import CustomUser, Staffs, Courses, Subjects, Students, Attendance, AttendanceReport, \
    LeaveReportStudent, StudentResult, Message


def student_home(request):
    students = Students.objects.get(admin=request.user.id)
    attendance_absent = AttendanceReport.objects.filter(student_id=students,
                                                        status=False).count()
    attendance_present = AttendanceReport.objects.filter(student_id=students,
                                                         status=True).count()
    total_attendance = AttendanceReport.objects.filter(student_id=students).count()

    course_obj = Courses.objects.get(id=students.course_id.id)
    total_subjects = Subjects.objects.filter(course_id=course_obj).count()
    context = {
            "total_attendance": total_attendance,
            "attendance_present": attendance_present,
            "attendance_absent": attendance_absent,
            "total_subjects": total_subjects
        }
    return render(request, "student_template/student_home_template.html",context)



def student_profile(request):
    user = CustomUser.objects.get(id=request.user.id)
    student = Students.objects.get(admin=user)
    context = {
        "user": user,
        "student": student
    }
    return render(request, 'student_template/student_profile.html', context)


def student_profile_update(request):
    if request.method != "POST":
        messages.error(request, "Invalid Method!")
        return redirect('student_profile')
    else:
        first_name = request.POST.get('first_name')
        last_name = request.POST.get('last_name')
        password = request.POST.get('password')
        address = request.POST.get('address')

        try:
            customuser = CustomUser.objects.get(id=request.user.id)
            customuser.first_name = first_name
            customuser.last_name = last_name
            if password != None and password != "":
                customuser.set_password(password)
            customuser.save()
            student = Students.objects.get(admin=customuser.id)
            student.address = address
            student.save()
            messages.success(request, "Profile updated successfully")
            return redirect('student_profile')
        except:
            messages.error(request, "Failed to update profile")
            return redirect('student_profile')


def student_view_result(request):
    student = Students.objects.get(admin=request.user.id)
    student_result = StudentResult.objects.filter(student_id=student.id)
    context = {
        "student_result": student_result,
    }
    return render(request, "student_template/student_view_result.html", context)


def student_view_attendance(request):
    student = Students.objects.get(admin=request.user.id)
    course = student.course_id
    subjects = Subjects.objects.filter(course_id=course)
    context = {
        "subjects": subjects
    }
    return render(request, "student_template/student_view_attendance.html", context)


def student_view_attendance_post(request):
    if request.method != "POST":
        messages.error(request, "Invalid Method")
        return redirect('student_view_attendance')
    else:
        start_date = request.POST.get('start_date')
        end_date = request.POST.get('end_date')
        start_date_parse = datetime.datetime.strptime(start_date, '%Y-%m-%d').date()
        end_date_parse = datetime.datetime.strptime(end_date, '%Y-%m-%d').date()
        subject_id = request.POST.get('subject')
        subject = Subjects.objects.get(id=subject_id)
        user = CustomUser.objects.get(id=request.user.id)
        stud_obj = Students.objects.get(admin=user)
        attendance = Attendance.objects.filter(attendance_date__range=(start_date_parse, end_date_parse),
                                               subject_id=subject)
        attendance_reports = AttendanceReport.objects.filter(attendance_id__in=attendance, student_id=stud_obj)

        context = {
            "subject_obj": subject,
            "attendance_reports": attendance_reports
        }

        return render(request, 'student_template/student_attendance_data.html', context)


def student_apply_leave(request):
    student = Students.objects.get(admin=request.user.id)
    data = LeaveReportStudent.objects.filter(student_id=student)
    context = {
        "leave_data": data
    }
    return render(request, 'student_template/student_apply_leave.html', context)


def student_apply_leave_save(request):
    if request.method != "POST":
        messages.error(request, "Invalid Method")
        return redirect('student_apply_leave')
    else:
        leave_date = request.POST.get('leave_date')
        leave_message = request.POST.get('leave_message')
        students = Students.objects.get(admin=request.user.id)
        try:
            leave_report = LeaveReportStudent(student_id=students, leave_date=leave_date,
                                              leave_message=leave_message, leave_status=0)
            leave_report.save()
            messages.success(request, "Applied for leave.")
            return redirect('student_apply_leave')
        except:
            messages.error(request, "Failed to apply leave")
            return redirect('student_apply_leave')

def create_messages(request):
    message = Message.objects.all()
    context = {"message": message}
    return render(request, "student_template/message.html", context)


def create_messages_save(request):
    if request.method != "POST":
        return HttpResponse("<h2>Not Allowed</h2>")
    else:
        user=request.POST.get("user")
        message=request.POST.get("message")
        try:
            message=Message(admin=user,message=message)
            message.save()
            messages.success(request, "Message added successfully")
            return redirect('create_message')
        except:
            messages.error(request, "Failed")
            return redirect('create_message')





