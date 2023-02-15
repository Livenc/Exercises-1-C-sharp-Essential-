namespace Exercise_2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            
            
            
            Console.Write("Input side 1 :" );
            if (!double.TryParse(Console.ReadLine(), out double side1) )
            {
                Console.WriteLine("Ne chislo");
            }
            Console.Write("Input side 2 :");
            if (!double.TryParse(Console.ReadLine(), out double side2))
            {
                Console.WriteLine("Ne chislo");
            }
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Area : "+rectangle.Area + " Perimeter : " + rectangle.Perimeter);
            Console.ReadLine();   
            
        }
    }
     class Rectangle
    {
        double side1,side2;
        public Rectangle(double side1,double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        double AreaCalculator()
        {
            return side1 * side2;
        }
        double PerimeterCalculator()
        {
            return 2*(side1 + side2);
        }
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}