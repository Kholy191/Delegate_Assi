using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }

        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string isbn, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            Price = price;
            PublicationDate = publicationDate;
        }

        public override string ToString()
        {
            string authorsList = string.Join(", ", Authors);
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {authorsList}, " +
                $"Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price}";
        }

    }

    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Authors);
        }

        public static string GetPrice(Book B)
        {
            return $"{B.Price}";
        }
    }
}
