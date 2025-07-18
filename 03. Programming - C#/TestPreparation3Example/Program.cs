using System;
using System.Collections.Generic;

namespace TestPreparation3Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Erika", "000000", "female", 5.4);
            Student s2 = new Student("Ivana", "121212", "female", 4.3);
            Student s3 = new Student("Ivan", "333333", "male", 5.8);

            Teacher t1 = new Teacher("Petrov", "111111", "male", 800);
            Teacher t2 = new Teacher("Georgieva", "222222", "female", 500);
            Teacher t3 = new Teacher("Todorov", "777777", "male", 1100);

            List<Person> p = new List<Person>();
            p.Add(s1);
            p.Add(s2);
            p.Add(s3);
            p.Add(t1);
            p.Add(t2);
            p.Add(t3);

            Student heighestAverageGrade = s1;

            for (int i = 0; i < p.Count; i++)
            {
                if(p[i] is Student)
                {
                    if (p[i].Gender == "female")
                    {
                        //no option to view teacher salary and student average grade
                        //alternative: to use two different lists for students and teachers
                }
            }   
        }
    }
}
