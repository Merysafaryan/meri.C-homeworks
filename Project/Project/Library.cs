using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> books;
        private List<User> users;

        public Library()
        {
            books = new List<Book>();
            users = new List<User>();
        }

        public void InitializeLibrary()
        {
            books.Add(new Book { Name = "The Lost City", Author = "B. R. Holmes", Id = 101 });
            books.Add(new Book { Name = "The 100 Names", Author = "Diango Wexler", Id = 102 });
            books.Add(new Book { Name = "Elementals", Author = "Michelle Madow", Id = 103 });
            books.Add(new Book { Name = "The Strong Tree", Author = "Thomas Carpenter", Id = 104 });
            books.Add(new Book { Name = "Breathe", Author = "Sarah Crossan", Id = 105 });
        }

        public void MainMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\t\t*************************************************");
                Console.WriteLine("\n\t\t\t\t      MAIN MENU: ");
                Console.WriteLine("\n\t\t\t\t     1. ISSUE OF BOOKS ");
                Console.WriteLine("\n\t\t\t\t     2. RETURN OF BOOKS ");
                Console.WriteLine("\n\t\t\t\t     3. SEARCH FOR A BOOK ");
                Console.WriteLine("\n\t\t\t\t     4. CHECK OUT A BOOK ");
                Console.WriteLine("\n\t\t\t\t     5. RETURN A BOOK ");
                Console.WriteLine("\n\t\t\t\t     6. RESERVE A BOOK ");
                Console.WriteLine("\n\t\t\t\t     7. EXIT\n ");
                Console.WriteLine("\n\t\t\t*************************************************");
                Console.WriteLine("\n\t\t\t\t      Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BookIssue();
                        break;
                    case 2:
                        BookReturn();
                        break;
                    case 3:
                        Console.WriteLine("\n\t Enter a search query (book title or author): ");
                        string searchQuery = Console.ReadLine();
                        SearchBook(searchQuery);
                        break;
                    case 4:
                        Console.WriteLine("\n\t Enter the Book ID to check out: ");
                        int bookIdCheckOut = int.Parse(Console.ReadLine());
                        CheckOutBook(bookIdCheckOut);
                        break;
                    case 5:
                        Console.WriteLine("\n\t Enter the Book ID to return: ");
                        int bookIdReturn = int.Parse(Console.ReadLine());
                        ReturnBook(bookIdReturn);
                        break;
                    case 6:
                        Console.WriteLine("\n\t Enter the Book ID to reserve: ");
                        int bookIdReserve = int.Parse(Console.ReadLine());
                        ReserveBook(bookIdReserve);
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n\t\t\t\t      ...Invalid Option!...\n");
                        Console.WriteLine("\n\t\t\t\t      Press any key to try again: ");
                        Console.ReadKey();
                        break;
                }
            } while (choice != 7);
        }

        public void BookIssue()
        {
            // Implementation for issuing a book
        }

        public void BookReturn()
        {
            // Implementation for returning a book
        }

        public void SearchBook(string query)
        {
            // Implementation for searching a book
        }

        public void CheckOutBook(int bookId)
        {
            // Implementation for checking out a book
        }

        public void ReturnBook(int bookId)
        {
            // 
        }

        public void ReserveBook(int bookId)
        {
            // 
        }
    }
}
