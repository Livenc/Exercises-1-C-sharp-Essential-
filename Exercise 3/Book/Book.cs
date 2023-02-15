using Exercise_3.Book.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Book
{
    internal class Book
    {
        Author author =null;
        Content content = null;
        Title title = null;

        void InitializeDocument()
        {
            this.author = new Author();
            this.content = new Content();
            this.title = new Title();
        }
        public Book()
        {
            InitializeDocument();
            
           
        }
        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

        public string Title
        {
            set
            {
                this.title.Contents = value; 
            }
        }
        public string Author
        {
            set
            {
                this.author.Contents = value;
            }
        }
        public string Content
        {
            set
            {
                this.content.Contents = value;
            }
        }
    }
}
