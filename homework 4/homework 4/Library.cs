using System;
using System.Collections.Generic;
using System.Linq;
using homework_4.Entities;
using homework_.Interfaces;

namespace homework_4.Entities
{
    public class Library : ILibrary
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        public void RemoveBook(string title)
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

        public void ListAllBooks()
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
    public void UpdateBookDetails(string title, int year, double price)
        {
            Book bookToUpdate = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToUpdate != null)
            {
                bookToUpdate.Year = year;
                bookToUpdate.Price = price;
                Console.WriteLine($"Details of book '{title}' updated successfully.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found in the library.");
            }
        }
              public List<Book> GetBooksByAuthor(string authorName)
        {
            return books.Where(b => b.Author.Name.Equals(authorName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }
}
