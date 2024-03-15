using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.InitializeLibrary();

            Console.WriteLine("\n\n\t\t\t     ****************************************");
            Console.WriteLine("\t\t\t     *     ----------------------------     *");
            Console.WriteLine("\t\t\t     *          WELCOME TO LIBRARY          *");
            Console.WriteLine("\t\t\t     *     ----------------------------     *");
            Console.WriteLine("\t\t\t     ****************************************");
            Console.WriteLine("\t\t\t     ****************************************");
            Console.WriteLine("\t\t\t     *       ------------------------       *");
            Console.WriteLine("\t\t\t     *              LIBRARY                 *");
            Console.WriteLine("\t\t\t     *       ------------------------       *");
            Console.WriteLine("\t\t\t     ****************************************");

            library.MainMenu();
        }
    }
}
