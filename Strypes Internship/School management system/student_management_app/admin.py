from django.contrib import admin
from django.contrib.auth.admin import UserAdmin
from .models import CustomUser, Adminn, Staffs, Courses, Subjects, Students,\
    Attendance, AttendanceReport, LeaveReportStudent, LeaveReportStaff, \
    Message
# Register your models here.
class UserModel(UserAdmin):
    pass


admin.site.register(CustomUser, UserModel)

admin.site.register(Adminn)
admin.site.register(Attendance)
admin.site.register(AttendanceReport)
admin.site.register(Staffs)
admin.site.register(LeaveReportStaff)
admin.site.register(Subjects)
admin.site.register(Message)
admin.site.register(Courses)
admin.site.register(Students)
admin.site.register(LeaveReportStudent)
