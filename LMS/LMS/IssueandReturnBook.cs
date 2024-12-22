using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class IssueandReturnBook
    {
        protected string BookName { get; set; }
        protected string BookIssueDate { get; set; }

        public IssueandReturnBook()
        {
            BookName = "Java";
            BookIssueDate = " 21-02-2022";
        }

        public IssueandReturnBook(string bookname, string bookissuedate)
        {
            BookName = bookname;
            BookIssueDate = bookissuedate;
        }

        public virtual void bookname()
        {
            Console.WriteLine("Write a Book Name: ");
        }

        public virtual void bookissuedate()
        {
            Console.WriteLine("Write a book issue date:  ");
        }

    }
}
