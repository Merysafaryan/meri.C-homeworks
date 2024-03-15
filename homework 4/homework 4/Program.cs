using System;
using homework_4.Entities;
using homework_4;
using homework_4.Entities;

namespace homework_4
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            var author1 = new Author("J.K. Rowling", "British author known for the Harry Potter series.");
            var category1 = new Category("Fantasy", "Books with magical elements and imaginary worlds.");
            var book1 = new Book("Harry Potter and the Sorcerer's Stone", author1, category1, 1997, 19.99);
            library.AddBook(book1);

            var author2 = new Author("George Orwell", "English novelist and essayist.");
            var category2 = new Category("Drama", "Books portraying a bleak future society.");
            var book2 = new Book("1984", author2, category2, 1949, 14.95);
            library.AddBook(book2);

            library.ListAllBooks();
        }
    }
}
