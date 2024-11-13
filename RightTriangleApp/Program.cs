namespace RightTriangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RightTriangleApp!");
            const double EPSILON = 0.000005;
            // double a = 0.0;
            // double b = 0.0;
            // double c = 0.0;
            bool isRight = false;

            Console.WriteLine("Please insert a, b, c (separate with key 'Enter')");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Format error, MUST be double. ");
            }
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Format error, MUST be double. ");
            }
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Format error, MUST be double. ");
            }

            isRight = Math.Abs(a * a - b * b - c * c) <= EPSILON;
            Console.WriteLine("The triangle is {0} right.", (isRight) ? " " : " not ");
            /// τριαδικος τελεστης αν ναι θα παρει το κενο , αν οχι θα παρει το not το στοιχειο {0}!!
        } 
    }
}
