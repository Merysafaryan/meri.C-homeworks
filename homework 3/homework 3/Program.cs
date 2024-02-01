using System;
using System.Collections.Generic;

namespace Homework3
{
    class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Book(string title, Author author, Category category, int year, double price)
        {
            Title = title;
            Author = author;
            Category = category;
            Year = year;
            Price = price;
        }
    }

    class Author
    {
        public string Name { get; set; }
        public string Biography { get; set; }

        public Author(string name, string biography)
        {
            Name = name;
            Biography = biography;
        }
    }

    sealed class Category
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Category(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
        }
    }

    static class LibraryManager
    {
        private static List<Book> books = new List<Book>();

        public static void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        public static void RemoveBook(string title)
        {
            Book bookToRemove = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Book '{title}' removed from the library.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found in the library.");
            }
        }

        public static void ListAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books found in the library.");
                return;
            }

            Console.WriteLine("List of all books in the library:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author.Name}");
                Console.WriteLine($"Category: {book.Category.CategoryName}");
                Console.WriteLine($"Year: {book.Year}");
                Console.WriteLine($"Price: ${book.Price}");
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var author1 = new Author("J.K. Rowling", "British author known for the Harry Potter series.");
            var category1 = new Category("Fantasy", "Books with magical elements and imaginary worlds.");
            var book1 = new Book("Harry Potter and the Sorcerer's Stone", author1, category1, 1997, 19.99);
            LibraryManager.AddBook(book1);

            var author2 = new Author("George Orwell", "English novelist and essayist.");
            var category2 = new Category("drama", "Books portraying a bleak future society.");
            var book2 = new Book("1984", author2, category2, 1949, 14.95);
            LibraryManager.AddBook(book2);

            LibraryManager.ListAllBooks();
        }
    }
}