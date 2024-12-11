using System;

namespace T3Activitats
{
    public class Program
    {
        public static void Main()
        {
            // Crear instancias de los objetos
            Books books = new Books(900, 1, 100, "Biblia", "1r", "Diosito", "Category 1", 929, "ISBN1");
            Magazine magazine = new Magazine(2021, 2, 200, "Tú", "2n", "AnnaHemming", "Category 2", "Youth", "Spanish");
            Diary diary = new Diary(2020, 3, 300, "Quarantine", "1r", "PaulaTenka", "Category 1", 99, "Daily");

            // Books
            Console.WriteLine("BOOK:");
            Console.WriteLine($"Name: {books.Name}\nDate: {books.Date}\nVolume: {books.Volume}\nPages: {books.Pages}");
            Console.WriteLine($"Author: {books.Author}\nEditorial: {books.Editorial}\nCategory: {books.Category}");
            books.ShowChapters();
            books.ShowISBN();
            Console.WriteLine("---------------------");

            // Magazine
            Console.WriteLine("MAGAZINE:");
            Console.WriteLine($"Name: {magazine.Name}\nDate: {magazine.Date}\nVolume: {magazine.Volume}\nPages: {magazine.Pages}");
            Console.WriteLine($"Author: {magazine.Author}\nEditorial: {magazine.Editorial}\nCategory: {magazine.Category}");
            magazine.ShowType();
            magazine.ShowLanguage();
            Console.WriteLine("---------------------");

            // Diary
            Console.WriteLine("DIARY:");
            Console.WriteLine($"Name: {diary.Name}\nDate: {diary.Date}\nVolume: {diary.Volume}\nPages: {diary.Pages}");
            Console.WriteLine($"Author: {diary.Author}\nEditorial: {diary.Editorial}\nCategory: {diary.Category}");
            diary.ShowDays();
            diary.ShowType();
            Console.WriteLine("---------------------");
        }
    }
}



