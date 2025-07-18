using System;
using System.Collections.Generic;
using System.Linq;


namespace DI2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(11465, "Ivan", "Petrov", "Plovdiv", "088856888", 4.3);
            Student s2 = new Student(13762, "Gergana", "Petrova", "Sofia", "089754444", 5.6);
            Student s3 = new Student(24381, "Georgi", "Petkov", "Varna", "0898333533", 5.2);

            List<Student> students = new List<Student>{ s1, s2, s3 };
            var result = findStudent(students);
            foreach(Student student in result){
                Console.WriteLine(student.ToString());
            }
        }

        public static IEnumerable<Student> findStudent(List<Student> students)
        {
            return students.Where(x => x.Grade >= 5 && x.LastName.Contains("Petrov"));
        }
    }
}
