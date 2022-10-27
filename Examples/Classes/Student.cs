using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Student : Person
    {
        // Class have two things 1.Field  2.Method
        // Field
        //public string name;
        

        //public DateTime dateOfBirth;
        

        //public string address;

        // Property
        // This Property is used instead of UpdateCgpa() Method
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

        // Field

        private double cgpa;

        private readonly string studentId = "";

        private const double MAX_CGPA = 4.0;


        // Method


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

        // Constructor or special Method
        // Invisible default constructor when there is no define constructor
        public Student() : this(string.Empty, string.Empty, DateTime.MinValue) // Constructor Chaining // Empty Constructor // Empty constructor basically use to set default value of an object Property
        {
            //Name = String.Empty;
            //Name = "N/A";
            //Address = String.Empty;
            //Address = "N/A";
            //DateOfBirth = DateTime.MinValue;
            //cgpa = 0;
            
        }

        public Student(string name, string address, DateTime dateOfBirth) : base("SD") // Parameterized Constructor
        {
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
            cgpa = 0;
        }

        public void UpdateDetails(string name)
        {
            Name = name;
        }

        //public void UpdateDetails(string address) // This is produce error brcause method name and paramter signature is same
        //{

        //}

        public void UpdateDetails(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void UpdateDetails(string address, object name)
        {

        }

        public void UpdateDetails(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public void UpdateDetails(string name, DateTime dateOfBirth)
        {

        }

        public void UpdateDetails(DateTime dateOfBirth, string name)
        {

        }

        public double UpdateDtails(DateTime dateOfBirth, string name)
        {
            throw new NotImplementedException();
        }

        // Real Life Example of Method Over Loading

        //public void AddProduct(Product product)
        //{

        //}

        //public void AddProduct(Product[] products)
        //{

        //}
    }
}
