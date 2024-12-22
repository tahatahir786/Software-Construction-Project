using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class AddNewBook : Book , IAddbooks
    {
        string BookName { get; set; }
        string BookAuthorName { get; set; }
        string BookPublication { get; set; }
        string BookPurchaseDate { get; set; }
        int BookPrice { get; set; }
        int BookQuantity { get; set; }


        public AddNewBook()
        {
            BookName = "JAVA";
            BookAuthorName = "Ali";
            BookPublication = "xy publication";
            BookPurchaseDate = "06-06-2022";
            BookPrice = 2500;
            BookQuantity = 5;

        }

        public AddNewBook(string bookname, string bookauthorname, string bookpublication, string bookpurchasedate, int bookprice, int bookquantity)
        {
            BookName = bookname;
            BookAuthorName = bookauthorname;
            BookPublication = bookpublication;
            BookPurchaseDate = bookpurchasedate;
            BookPrice = bookprice;
            BookQuantity = bookquantity;
        }

        public override void bookname()
        {
            BookName = Console.ReadLine();
        }

        public override void bookauthorname()
        {
           BookAuthorName= Console.ReadLine();
        }

        public override void bookpublication()
        {
            BookPublication= Console.ReadLine();
        }

        public override void bookprice()
        {
            BookPrice= Convert.ToInt32(Console.ReadLine());
        }

        public override void bookquantity()
        {
            BookQuantity= Convert.ToInt32(Console.ReadLine());
        }

        public void save()
        {
            Console.WriteLine("All information is saved");
        }

        public void cancel()
        {
            Console.WriteLine("Are you sure you want to cancel");
        }
    }
}
