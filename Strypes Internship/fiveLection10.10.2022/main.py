class SchoolMember:
    def __init__(self,name,age):
      self.name=name
      self.age=int(age)

class Teacher(SchoolMember):
    def __init__(self,name,age,salary,courses):
        super(Teacher, self).__init__(name,age)
        self.salary=salary
        self.courses=courses

class Student(SchoolMember):
    def __init__(self,name,age,courses,subjectEnrollDate,*subjectGrade):
        super(Student, self).__init__(name,age)
        self.courses=courses
        self.subjectEnrollDate=subjectEnrollDate
        self.subjectGrade=subjectGrade

