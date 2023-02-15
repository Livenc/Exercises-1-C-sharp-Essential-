using Exercise_3.Book;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book.Book book = new Book.Book();
            book.Title = "sd";
            book.Author = "Dickens";
            book.Content = "la la a ala l a";
            book.Show();
            Console.ReadKey();
        }
    }
}