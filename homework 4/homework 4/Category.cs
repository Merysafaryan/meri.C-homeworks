using System;

namespace homework_4.Entities
{
    public sealed class Category
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Category(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Category: {CategoryName}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}

