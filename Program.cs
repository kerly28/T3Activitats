using System;

namespace T3Activitats
{
    public class Program
    {
        public static void Main()
        {
            // Crear llibres
            Book book1 = new Book("Shingeki No Kyojin", "Hajime Isayama");
            Book book2 = new Book("Ao Haru Ride", "Io Sakisaka");
            Book[] books = { book1, book2 };

            // Crear una biblioteca amb llibres
            Library library = new Library("Barcelona", "Biblioteca de Roquetes", books);

            // Missatges
            Console.WriteLine("Library: " + library.Name + " - " + library.Location);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Books in the library:");
            foreach (var book in library.Books)
            {
                Console.WriteLine(" - " + book.Title + " by " + book.Author);
            }
        }
    }
}
