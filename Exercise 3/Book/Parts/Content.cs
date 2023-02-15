using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Book.Parts
{
    internal class Content
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Contents);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
