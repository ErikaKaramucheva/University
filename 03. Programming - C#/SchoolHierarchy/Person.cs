﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolHierarchy
{
    public abstract class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
