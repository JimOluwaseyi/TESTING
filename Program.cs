using System;

namespace myConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Ensure the Testing class is available
            Testing test = new Testing();
            test.Run();

            // Create instances of Book
            Book book1 = new Book("Jim", "Be a Man");
            Book book2 = new Book("Subby", "My Friend");
            Book book3 = new Book("A.J", "Effortless English");

            // Run the method to display details
            book1.Run();
            book2.Run();
            book3.Run();
        }
    }
}
