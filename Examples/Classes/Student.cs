using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Student
    {
        // Class have two things 1.Field  2.Method
        // Field
        //public string name;
        public string Name { get; set; }

        //public DateTime dateOfBirth;
        public DateTime DateOfBirth { get; set; }

        //public string address;
        public string Address { get; set; }

        private double cgpa;
        

        // Method
        /*
        public double GetCgpa()
        {
            return cgpa;
        }
        public void UpdateCgpa(double newCgpa)
        {
            if (newCgpa >= 0)
            {
                cgpa = newCgpa;
            }
        }
        */

        // Property
        public double Cgpa
        {
            get
            {
                return cgpa;
            }
            set
            {
                if (value >= 0)
                {
                    cgpa = value;
                }
            }
        }
    }
}
