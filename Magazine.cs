using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3Activitats
{
    public class Magazine : Publication
    {
        //Getters and Setters
        public string Type { get; set; }
        public string Language { get; set; }

        //Constructor
        public Magazine(int date, int volume, int pages, string name, string editorial, string author, string category, string type, string language) : base(date, volume, pages, name, editorial, author, category)
        {
            Type = type;
            Language = language;
        }

        //Comportament
        public void ShowType()
        {
            Console.WriteLine("The type of the magazine is {0}", Type);
        }
        public void ShowLanguage() {
            Console.WriteLine("The language of the magazine is {0}", Language);
        }
    }
}
