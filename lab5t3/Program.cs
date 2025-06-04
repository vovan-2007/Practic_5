namespace lab5t3
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
        static int FactSumm(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Factorial(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FactSumm(5));
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
