namespace lab5t24
{
    internal class Program
    {
        static int minimum(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(minimum(10, 8, 5));
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
