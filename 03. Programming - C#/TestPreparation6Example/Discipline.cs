using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation6Example
{
    class Discipline:Teacher
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int numberOfLectures;
        public int NumberOfLectures
        {
            get
            {
                return numberOfLectures;
            }
            set
            {
                numberOfLectures = value;
            }
        }

        private int numberOfExercise;
        public int NumberOfExercise
        {
            get
            {
                return numberOfExercise;
            }
            set
            {
                numberOfExercise = value;
            }
        }


    }
}
