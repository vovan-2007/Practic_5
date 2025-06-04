namespace lab5t13
{
    internal class Program
    {
        static void fibon(int M)
        {
            int a = 0, b = 1;
            Console.Write(a + " ");

            while (b <= M)
            {
                Console.Write(b + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            fibon(10);
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
