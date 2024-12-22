using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class ReturnedBooks : CompleteBookDetail
    {

        string Student_Name;
        string Department;
        int Student_semester;
        int Student_Contact;
        string Student_Email;
        string BookName;
        string BookIssueDate;
        string BookReturnDate;

        public ReturnedBooks()
        {
            Student_Name = "Adnan";
            Department = "CS";
            Student_semester = 6;
            Student_Contact = 658678955;
            Student_Email = "Adnan@gmail.com";
            BookName = "C#";
            BookIssueDate = "23-06-2021";
            BookReturnDate = "30-06-2021";
        }

        public void setData(string student_name, string department, int student_semester, int student_contact, string student_email, string bookname, string bookissuedate, string bookreturndate)
        {
            Student_Name = student_name;
            Department = department;
            Student_semester = student_semester;
            Student_Contact = student_contact;
            Student_Email = student_email;
            BookName = bookname;
            BookIssueDate = bookissuedate;
            BookReturnDate = bookreturndate;
        }

        public void GetStudent_Name()
        {
            Console.WriteLine("Student Name: " + Student_Name);
        }

        public void GetDepartment()
        {
            Console.WriteLine("Student Department: " + Department);
        }


        public void GetStudent_Semester()
        {
            Console.WriteLine("Student Semester: " + Student_semester);
        }

        public void GetStudent_Contact()
        {
            Console.WriteLine("Student Contact Number: " + Student_Contact);
        }

        public void GetStudent_Email()
        {
            Console.WriteLine("Student Email: " + Student_Email);
        }

        public override void GetBookName()
        {
            Console.WriteLine("Book Name: " + BookName);

        }

        public override void GetBookIssueDate()
        {
            Console.WriteLine("Book Issue Date: " + BookIssueDate);
        }

        public void GetBookReturnDate()
        {
            Console.WriteLine("Book Return Date: " + BookReturnDate);
        }
    }
}
