﻿using System;

namespace T3Activitats
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }
    }
}
