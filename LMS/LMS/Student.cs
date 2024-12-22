using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class Student
    {
        protected string Student_Name { get; set; }
        protected int Enrollment_No { get; set; }
        protected string Department { get; set; }
        protected int Student_Semester { get; set; }
        protected int Student_Contact { get; set; }
        protected string Student_Email { get; set; }

        public Student()
        {
            Student_Name = "Ali";
            Enrollment_No = 1475;
            Department = "Electrical";
            Student_Semester = 2;
            Student_Contact = 02365478;
            Student_Email = "Ali@gmail.com";

        }

        public Student(string student_name, int enrollment_no, string department, int student_semester, int student_contact, string student_email)
            {
            Student_Name = student_name;
            Enrollment_No = enrollment_no;
            Department = department;
            Student_Semester = student_semester;
            Student_Contact = student_contact;
            Student_Email = student_email;

            }

        public virtual void student_name()
        {
            Console.WriteLine("Write a student name: ");
        }

        public virtual void enrollment_no()
        {
            Console.WriteLine("Write a enrollment number: ");
        }

        public virtual void department()
        {
            Console.WriteLine("Write a department name: ");
        }

        public virtual void student_semester()
        {
            Console.WriteLine("Write a student semester: ");
        }

        public virtual void student_contact()
        {
            Console.WriteLine("Write a student contact number: ");
        }

        public virtual void student_email()
        {
            Console.WriteLine("Write a student email: ");
        }

    }
}
