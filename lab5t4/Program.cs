namespace lab5t4
{
    internal class Program
    {
        static int Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
        static double SummofFact(int n)
        {
            double sum = 1.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / Factorial(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SummofFact(5));
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
