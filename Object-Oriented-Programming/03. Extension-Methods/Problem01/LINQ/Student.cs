﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.LINQ
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        
        public Student()
        {

        }

        public Student(string firstName, string lastName, int age, int fN, string tel,
            string mail, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FN = fN;
            this.Tel = tel;
            this.Mail = mail;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }


    }
}
