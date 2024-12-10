using System;

namespace T3Activitats
{
    public class Library
    {
        public string Location { get; set; }
        public string Name { get; set; }
        public Book[] Books { get; set; }

        public Library(string Location, string name, Book[] books)
        {
            this.Location = Location;
            this.Name = name;
            this.Books =books;
        }
    }
}
