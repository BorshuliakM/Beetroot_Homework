using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Book
    {
        public int Id;
        public string Name;
        public string Author;
        public List<string> Genre;
        public Book(int Id, string Name, List<string> Genre, string Author)
        {
            this.Id = Id;
            this.Name = Name;
            this.Genre = Genre;
            this.Author = Author;
        }
        public void PrintBook()
        {
            Console.WriteLine($"Book name: {Name}\nAuthor: {Author}");
            Console.WriteLine("Genre: ");
            foreach ( var item in Genre ) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
