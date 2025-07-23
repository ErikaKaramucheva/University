class SchoolMember():
    name:str
    age:int
    def __init__(self,name,age):
        self.name=name
        self.age=age

class Teacher(SchoolMember):
    salary:float
    courses={}
    def __init__(self,name,age,salary):
        super().__init__(self,name,age)
        self.salary=salary
        self.courses = {}
    def getSalary(self):
        return self.salary
    def addCourse(self,sign,course_Name):
        self.courses[sign]=course_Name
    def getCourses(self):
       return "\n".join(f'{k} {v}' for k,v in self.courses.items())

class Student(SchoolMember):
    courses={}
    def __init__(self,name,age):
        super().__init__(name,age)
        self.courses = {}
    def attendCourse(self,course,year):
        self.courses[course]= {'grade':[], 'year':year}
    def addGrade(self,course,*grade):
        if course in self.courses:
            self.courses[course]['grade'].extend(x for x in grade)
    def getCourses(self):
        return "\n".join(f'{k} {v}' for k, v in self.courses.items())
    def getAvgGrade(self,course):
        return sum(self.courses[course]['grade'])/len(self.courses[course]['grade'])

