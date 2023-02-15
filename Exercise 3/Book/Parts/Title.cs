using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Book.Parts
{
    internal class Title
    {
        string content;

        public string Contents
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Contents);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
