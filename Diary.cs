using System;

namespace T3Activitats
{
    public class Diary:Publication
    {
        //Getters and Setters
        public int Days { get; set; }
        public string Type { get; set; }
        //Constructor
        public Diary(int date, int volume, int pages, string name, string editorial, string author, string category, int days, string type) : base(date, volume, pages, name, editorial, author, category)
        {
            Days = days;
            Type = type;
        }
        //Comportament
        public void ShowDays()
        {
            Console.WriteLine("The diary has {0} days", Days);
        }
        public void ShowType()
        {
            Console.WriteLine("The type of the diary is {0}", Type);
        }
    }
}
