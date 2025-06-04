namespace lab5t8
{
    internal class Program
    {
        static double delenie(double x)
        {
            double sum = 0;
            int y = 1;
            for (int i = 1; i <= 11; i += 2)
            {
                sum += y * Math.Pow(x, i) / i;
                y = -y;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(delenie(10));
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
