using System;


namespace T3Activitats
{
    public class Books: Publication
    {
        //Getters and Setters
        public int Chapters { get; set; } 

        public string ISBN { get; set; }
        //Constructor
        public Books(int date, int volume, int pages, string name, string editorial, string author, string category, int chapters, string isbn) : base(date, volume, pages, name, editorial, author, category)
        {
            Chapters = chapters;
            ISBN = isbn;
        }
        //Comportaments
        public void ShowChapters()
        {
            Console.WriteLine("The book has {0} chapters", Chapters);
        }

        public void ShowISBN()
        {
            Console.WriteLine("The ISBN of the book is {0}", ISBN);
        }
    }
}
