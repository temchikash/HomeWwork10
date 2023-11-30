using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Classwork12
{
    class Book
    {
        public string author;
        public string title;
        public string publishing;
        public Book(string author, string title, string publishing, BookContainer bc)
        {
            this.author = author;
            this.title = title;
            this.publishing = publishing;
            bc.books.Add(this);
        }
        public static int CompareByTitle(Book b1, Book b2)
        {
            return String.Compare(b1.title, b2.title);
        }
        public static int CompareByAuthor(Book b1, Book b2)
        {
            return String.Compare(b1.author, b2.author);
        }
        public static int CompareByPublishing(Book b1, Book b2)
        {
            return String.Compare(b1.publishing, b2.publishing);
        }
    }
    class BookContainer
    {
        public List<Book> books = new List<Book>();
        public void Sort(Comparison<Book> comparison)
        {
            books.Sort(comparison);
        }
        public void Show()
        {
            foreach(Book b in books)
            {
                Console.WriteLine("{0} - {1} - {2}", b.author, b.title, b.publishing);
            }
        }
    }
}
