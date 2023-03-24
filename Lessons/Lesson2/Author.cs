using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Author
    {
        public int id;
        public string Name;
        public List<Book> books;
        public Author(int id, string Name, List<Book> books) 
        {
            this.id = id;
            this.Name = Name;
            this.books = books;
        }
        public void PrintAuthor()
        {
            Console.WriteLine($"Name: {Name}\nBooks:");
            foreach(Book book in books) 
            { 
                Console.WriteLine(book.Name);
            }
        }
    }
}
