using System;


namespace T3Activitats
{
    public class Publication
    {
        public int Date { get; set; }

        public int Volume { get; set; }

        public int Pages { get; set; }
        public string Name { get; set; }
        
        public string Editorial { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public Publication(int date, int volume, int pages, string name, string editorial, string author, string category)
        {
            Date = date;
            Volume = volume;
            Pages = pages;
            Name = name;
            Editorial = editorial;
            Author = author;
            Category = category;
        }
    }
}
