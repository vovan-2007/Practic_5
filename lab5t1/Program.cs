namespace lab5t1
{
    internal class Program
    {
        static void Print(int M, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(M + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Print(10, 10);
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
