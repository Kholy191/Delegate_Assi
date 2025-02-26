﻿using System.Reflection.Metadata.Ecma335;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q(a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.

            //List<Book> books = new List<Book>();
            //books.Add(new Book(
            //        isbn: "71",
            //        title: "Numbers",
            //        authors: new string[] { "Ahmed", "Mahmoud" },
            //        publicationDate: new DateTime(2010, 11, 22),
            //        price: 233
            //        ));

            //BookFunc Func1 = BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooks(books, Func1);

            #endregion

            #region Q(b) Use the Proper build in delegate. 

            //List<Book> books = new List<Book>();
            //books.Add(new Book(
            //        isbn: "71",
            //        title: "Numbers",
            //        authors: new string[] { "Ahmed", "Mahmoud" },
            //        publicationDate: new DateTime(2010, 11, 22),
            //        price: 233
            //        ));

            //Func<Book,string> Func1 = BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooks(books, Func1);

            #endregion

            #region Q(c) Anonymous Method (GetISBN).

            //List<Book> books = new List<Book>();
            //books.Add(new Book(
            //        isbn: "71",
            //        title: "Numbers",
            //        authors: new string[] { "Ahmed", "Mahmoud" },
            //        publicationDate: new DateTime(2010, 11, 22),
            //        price: 233
            //        ));

            //Func<Book, string> GetISBN = delegate (Book book) { return book.ISBN; };

            //LibraryEngine.ProcessBooks(books, GetISBN);


            #endregion

            #region Q (d) Lambda Expression (GetPublicationDate).

            //List<Book> books = new List<Book>();
            //books.Add(new Book(
            //        isbn: "71",
            //        title: "Numbers",
            //        authors: new string[] { "Ahmed", "Mahmoud" },
            //        publicationDate: new DateTime(2010, 11, 22),
            //        price: 233
            //        ));
            //LibraryEngine.ProcessBooks(books, X => X.PublicationDate.ToString());

            #endregion

        }
    }
}
