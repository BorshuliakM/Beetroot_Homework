using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{

    internal class Book_library
    {
        public string Library_Name;
        public List<Book> Books;
        public List<Author> Authors;
        public Book_library(string Library_Name, List<Book> Books, List<Author> Authors)
        {
            this.Library_Name = Library_Name;
            this.Books = Books;
            this.Authors = Authors;
        }
        public void Bookadd(Book book)
        {
            Books.Add(book);
        }
        public void Authoradd(Author author)
        {
            Authors.Add(author);
        }
        public void Print()
        {
            Console.WriteLine($"Books in library: ");
            foreach (Book book in Books)
            {
                Console.WriteLine(book.Name);
            }
            Console.WriteLine($"\nAuthors in library: ");
            foreach (Author author in Authors)
            {
                Console.WriteLine(author.Name);
            }
        }
    }
}
