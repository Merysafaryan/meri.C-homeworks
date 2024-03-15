using System;

namespace homework_4.Entities
{
    public class Author : IAuthor
    {
        public string Name { get; set; }
        public string Biography { get; set; }

        public Author(string name, string biography)
        {
            Name = name;
            Biography = biography;
        }
    public void DisplayDetails()
        {
            Console.WriteLine($"Author: {Name}");
            Console.WriteLine($"Biography: {Biography}");
        }

        public bool HasWrittenBook(string bookTitle)
        {
            return true;
        }
    }
}
