namespace lab5t16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int calculations(double deposit, double percent, double target)
            {
                int months = 0;
                while (deposit < target)
                {
                    deposit += deposit * (percent / 100);
                    months++;
                }
                return months;
            }
            static void Main(string[] args)
            {
                Console.WriteLine(calculations(100000, 11, 1000000));
                Console.WriteLine("Нажмите любую клвашишу для завершения...");
                Console.ReadKey();
            }
    }
}
