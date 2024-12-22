using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class AddStudents : Student , IAddStudent
    {
        string Student_Name { get; set; }
        int Enrollment_No { get; set; }
        string Department { get; set; }
        int Student_Semester { get; set; }
        int Student_Contact { get; set; }
        string Student_Email { get; set; }


        public AddStudents()
        {
            Student_Name = "Ahmed";
            Enrollment_No = 1464;
            Department = "Avionics";
            Student_Semester = 3;
            Student_Contact = 13325478;
            Student_Email = "Ahmed@gmail.com";

        }

        public AddStudents(string student_name, int enrollment_no, string department, int student_semester, int student_contact, string student_email)
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
            Student_Name = Console.ReadLine();
        }

        public override void enrollment_no()
        {
            Enrollment_No = Convert.ToInt32(Console.ReadLine());
        }


        public override void department()
        {
            Department = Console.ReadLine();
        }

        public override void student_semester()
        {
            Student_Semester = Convert.ToInt32(Console.ReadLine());
        }

        public override void student_contact()
            {

            Student_Contact= Convert.ToInt32(Console.ReadLine());

            }

        public override void student_email()
        {
           Student_Email = Console.ReadLine();
        }

        public void refresh()
        {
            Console.WriteLine("All information is refresh");
        }

        public void save()
        {
            Console.WriteLine("All information is  save");
        }

        public void Exit()
        {
            Console.WriteLine("Exit");
        }
    }
}
