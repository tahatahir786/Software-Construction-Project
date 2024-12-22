using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    abstract class CompleteBookDetail
    {
        string BookName;
        string BookIssueDate;

        public string bookname { get { return BookName; } set { BookName = value;  } }
        public string bookissuedate { get { return BookIssueDate; } set { BookIssueDate = value; } }

        public abstract void GetBookName();


        public abstract void GetBookIssueDate();
      
    }
}
