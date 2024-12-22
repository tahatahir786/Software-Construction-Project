using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class IssueBook : IssueandReturnBook, IIssueBooks
    {
        protected string Student_Name { get; set; }
        protected string Department { get; set; }
        protected int Student_semester { get; set; }
        protected int Student_Contact { get; set; }
        protected string Student_Email { get; set; }
        protected string BookName { get; set; }
        protected string BookIssueDate { get; set; }

        public IssueBook()
        {
            Student_Name = "Adnan";
            Department = "CS";
            Student_semester = 6;
            Student_Contact = 658678955;
            Student_Email = "Adnan@gmail.com";
            BookName = "C#";
            BookIssueDate = "23-06-2021";
        }

        public IssueBook(string student_name,string department,int student_semester,int student_contact,string student_email, string bookname, string bookissuedate)
        {
            Student_Name = student_name;
            Department = department;
            Student_semester = student_semester;
            Student_Contact = student_contact;
            Student_Email = student_email;
            BookName = bookname;
            BookIssueDate = bookissuedate;
        }

         public void student_name()
        {
            Student_Name = Console.ReadLine();
        }

        public void department()
        {
            Department = Console.ReadLine();
        }

        public  void student_semester()
        {
            Student_semester = Convert.ToInt32(Console.ReadLine());
        }

        public void student_contact()
        {
            Student_Contact = Convert.ToInt32(Console.ReadLine());
        }

        public void student_email()
        {
            Student_Email = Console.ReadLine();
        }

        public override void bookname()
        {
            BookName = Console.ReadLine();
        }

        public override void bookissuedate()
        {
            BookIssueDate= Console.ReadLine();
        }

        public void refresh()
        {

            Console.WriteLine("All information is refresh or clear");
        }

        public void Exit()
        {
            Console.WriteLine("Exit");
        }

        public void issuebook()
        {

            Console.WriteLine("Book is issued");
        }

        public void SearchStudent()
        {

            Console.WriteLine("Search Student");
        }
    }
}


