namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point q = new Point(1,12);
            Point x = new Point(5, 20);
            Point y = new Point(10, 40);
            Point z = new Point(12, 1);
            Point s = new Point(5, 20);

            Figure figure = new Figure(q,x,y);
            figure.PerimeterCalculator();
            Figure figure1 = new Figure(q, x, y, z);
            figure1.PerimeterCalculator();
            Figure figure2 = new Figure(q, x, y, z,s);
            figure2.PerimeterCalculator();
            Console.ReadLine();
        }
    }
}