namespace lab5t25
{
    internal class Program
    {
        static int min(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        static int min(int a, int b, int c, int d)
        {
            return Math.Min(min(a, b, c), d);
        }
        static int min(int a, int b, int c, int d, int e)
        {
            return Math.Min(min(a, b, c, d), e);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(min(10, 8, 5));
            Console.WriteLine(min(14, 12, 10, 8));
            Console.WriteLine(min(14, 12, 10, 8, 6));
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
