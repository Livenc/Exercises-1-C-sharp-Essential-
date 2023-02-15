using Exercise_3.Book;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book.Book book = new Book.Book();
            book.Title = "No Wind of Blame";
            book.Author = "Georgette Heyer";
            book.Content = "Want to know how to shoot a man- without being near the murder weapon when its fired?\r\n\r\nIf you do (and no doubt you have your own very good reasons for wanting to know such a fiendish trick) you'll find the answer in this masterly detective novel.";
            book.Show();
            Console.ReadKey();
        }
    }
}