using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class ViewStudentInfo : Student , IViewBook
    {
        public ViewStudentInfo()
        {
            Student_Name = "Ahmed";
            Enrollment_No = 1464;
            Department = "Avionics";
            Student_Semester = 3;
            Student_Contact = 13325478;
            Student_Email = "Ahmed@gmail.com";

        }

        public ViewStudentInfo(string student_name, int enrollment_no, string department, int student_semester, int student_contact, string student_email)
        {
            Student_Name = student_name;
            Enrollment_No = enrollment_no;
            Department = department;
            Student_Semester = student_semester;
            Student_Contact = student_contact;
            Student_Email = student_email;

        }

        public override void student_name()
        {
            Console.WriteLine("Student Name: " + Student_Name);
        }

        public override void enrollment_no()
        {
            Console.WriteLine("Enrollment Number: " + Enrollment_No);
        }

        public override void department()
        {
            Console.WriteLine("Department: " + Department);
        }

        public override void student_semester()
        {
            Console.WriteLine("Student Semester: " + Student_Semester);
        }

        public override void student_contact()
        {
            Console.WriteLine("Student Contact Number: " + Student_Contact);
        }

        public override void student_email()
        {
            Console.WriteLine("Student Email: " + Student_Email);
        }

        public void displaystudentinfo()
        {
            student_name();
            enrollment_no();
            department();
            student_semester();
            student_contact();
            student_email();
        }

       

        public void cancel()
        {
            Console.WriteLine("Are you sure you want to cancel");
        }

        public void update()
        {
            Console.WriteLine("All information is updated");
        }

        public void delete()
        {
            Console.WriteLine("All information is deleted");
        }

        public void refresh()
        {
            Console.WriteLine("All information is refresh");
        }
    }
}
