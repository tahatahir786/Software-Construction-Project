using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class IssuedBooks : CompleteBookDetail
    {
        string Student_Name;
        string Department;
        int Student_semester;
        int Student_Contact;
        string Student_Email;
        string BookName;
        string BookIssueDate;

        public IssuedBooks()
        {
            Student_Name = "Adnan";
            Department = "CS";
            Student_semester = 6;
            Student_Contact = 658678955;
            Student_Email = "Adnan@gmail.com";
            BookName = "C#";
            BookIssueDate = "23-06-2021";
        }

        public void setData(string student_name, string department, int student_semester, int student_contact, string student_email, string bookname, string bookissuedate)
        {
            Student_Name = student_name;
            Department = department;
            Student_semester = student_semester;
            Student_Contact = student_contact;
            Student_Email = student_email;
            BookName = bookname;
            BookIssueDate = bookissuedate;
        }

        public void GetStudent_Name()
        {
            Student_Name = Console.ReadLine();
        }

        public void GetDepartment()
        {
            Department = Console.ReadLine();
        }


        public void GetStudent_Semester()
        {
            Student_semester = Convert.ToInt32(Console.ReadLine());
        }

        public void GetStudent_Contact()
        {
            Student_Contact = Convert.ToInt32(Console.ReadLine());
        }

        public void GetStudent_Email()
        {
            Student_Email = Console.ReadLine();
        }

        public override void GetBookName()
        {
            BookName = Console.ReadLine();

        }

        public override void GetBookIssueDate()
        {
            BookIssueDate = Console.ReadLine();
        }

       
    
    }
}
