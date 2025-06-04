namespace lab5t22
{
    internal class Program
    {
        static int pow(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(pow(10, 2));
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
