using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class ReturnBooks : IssueandReturnBook , IReturnBook
    {
        public ReturnBooks()
        {
            BookName = "OOP";
            BookIssueDate = "25-04-2022";
        }

        public ReturnBooks(string bookname, string bookissuedate)
        {
            BookName = bookname;
            BookIssueDate = bookissuedate;
        }

        public override void bookname()
        {
            Console.WriteLine("Book Name: " + BookName);
        }

        public override void bookissuedate()
        {
            Console.WriteLine("Book Issue Date: " + BookIssueDate);
        }

        public void refresh()
        {

            Console.WriteLine("All information is refresh");
        }

        public void Exit()
        {
            Console.WriteLine("Exit");
        }

        public void Return()
        {

            Console.WriteLine("Book is return");
        }

        public void SearchStudent()
        {

            Console.WriteLine("Search Student");
        }

        public void cancel()
        {
            Console.WriteLine("cancel");
        }

    }

}
