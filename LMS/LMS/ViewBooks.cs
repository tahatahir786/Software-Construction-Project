using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class ViewBooks : Book, IViewBook
    {
        public ViewBooks()
        {
            BookName = "C";
            BookAuthorName = "Fayyaz Khana";
            BookPublication = "pom publication";
            BookPurchaseDate = "20-06-2022";
            BookPrice = 2000;
            BookQuantity = 6;

        }

        public ViewBooks(string bookname, string bookauthorname, string bookpublication, string bookpurchasedate, int bookprice, int bookquantity)
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
            Console.WriteLine("Book Name: " + BookName);
        }

        public override void bookauthorname()
        {
            Console.WriteLine("Book Author Name: " + BookAuthorName);
        }

        public override void bookpublication()
        {
            Console.WriteLine("Book Publication: " + BookPublication);
        }

        public override void bookprice()
        {
            Console.WriteLine("Book Price: " + BookPrice);
        }

        public override void bookquantity()
        {
            Console.WriteLine("Book Quantity: " + BookQuantity);
        }

        public void displaybooks()
        {
            bookname();
            bookauthorname();
            bookpublication();
            bookquantity();
            bookprice();
        }

        public void update()
        {
            Console.WriteLine("All Information will be updated");
        }

        public void delete()
        {
            Console.WriteLine("All Information will be deleted");
        }

        public void cancel()
        {
            Console.WriteLine("Are you sure you want to cancel");
        }

        public void refresh()
        {
            Console.WriteLine("All information is refresh or clear");
        }
    }
}
