using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    internal class Program
    {
        class Book
        {
            public string Title;
            public string Author;
        }
        static void Main(string[] args)
        {
            Book testBook = new Book();
            testBook.Title = "HarryPotter";
            testBook.Author = "J.K.Rowling";

            Console.WriteLine("Book Name: " + testBook.Title + "\nBook Author: " + testBook.Author);
            Console.ReadLine();
        }
    }
}
