namespace lab5t7
{
    internal class Program
    {
        static double delenie(int n)
        {
            double sum = 0;
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += x * (1.0 / i);
                x = -x;
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
