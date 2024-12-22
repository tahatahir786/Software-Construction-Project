using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class Book
    {
        protected string BookName { get; set; }
        protected string BookAuthorName { get; set; }
        protected string BookPublication { get; set; }
        protected string BookPurchaseDate { get; set; }
        protected int BookPrice { get; set; }
        protected int BookQuantity { get; set; }

        public Book()
        {
            BookName = "oop";
            BookAuthorName = "Ahmad";
            BookPublication ="xyz publication";
            BookPurchaseDate = "14-06-2022";
            BookPrice = 2500;
            BookQuantity = 5;

        }

        public Book(string bookname,string bookauthorname,string bookpublication, string bookpurchasedate, int bookprice, int bookquantity)
        {
            BookName = bookname;
            BookAuthorName = bookauthorname;
            BookPublication = bookpublication;
            BookPurchaseDate = bookpurchasedate;
            BookPrice = bookprice;
            BookQuantity = bookquantity;
        }

        public virtual void bookname()
        {
            Console.WriteLine("Write a book name");
        }

        public virtual void bookauthorname()
        {
            Console.WriteLine("Write a book author name");
        }

        public virtual void bookpublication()
        {
            Console.WriteLine("Write a book publication date");
        }

        public virtual void bookpurchasedate()
        {
            Console.WriteLine("Write a book purchase date");
        }

        public virtual void bookprice()
        {
            Console.WriteLine("Write a book price");
        }

        public virtual void bookquantity()
        {
            Console.WriteLine("Write a book quantity");
        }
    }
}
