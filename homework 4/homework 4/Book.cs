using System;

namespace homework_4.Entities
{
    public class Book : IBook
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
        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author.Name}");
            Console.WriteLine($"Category: {Category.CategoryName}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine();
        }

        public int CalculateAge()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - Year;
        }

        public bool IsInCategory(string categoryName)
        {
            return Category.CategoryName.Equals(categoryName, StringComparison.OrdinalIgnoreCase);
        }

    }
}

