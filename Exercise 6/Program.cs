namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address(61176, "Ukraine", "Kharkiv", "Svoboda", 16, 23);
            address.Show();
            Console.ReadKey();
        }
    }
}