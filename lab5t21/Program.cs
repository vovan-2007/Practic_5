namespace lab5t21
{
    internal class Program
    {
        static double triangleP(double a, double b, double c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(triangleP(10, 6, 4));
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();

        }
    }
}
