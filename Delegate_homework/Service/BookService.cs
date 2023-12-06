using Delegate_homework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_homework.Service
{
    internal class BookService
    {
        public delegate bool CheckByAuthor(Book book);

        public void SortByAuthor(List<Book>books, CheckByAuthor check )
        {
            int count = 0;
            foreach(Book book in books)
            {
                if (check(book))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public void ShowResult()
        {
            List<Book>books = new List<Book>();
            books.Add(new Book { Id=1,Author="Nizami",Title="Fitne"});
            books.Add(new Book { Id = 2, Author = "Nizami", Title = "Iki Ressam" });
            books.Add(new Book { Id = 3, Author = "Nizami", Title = "Ogluma Nesihet" });
            books.Add(new Book { Id = 4, Author = "Abbas Sehhet", Title = "Siniq Saz" });
            books.Add(new Book { Id = 5, Author = "Ehmed Cavad", Title = "Dalga" });
            books.Add(new Book { Id = 6, Author = "Ehmed Cavad", Title = "Haqq Bagiran Ses" });

            SortByAuthor(books, book => book.Author =="Nizami");
        }
    }
}
