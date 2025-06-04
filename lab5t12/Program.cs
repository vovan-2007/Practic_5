namespace lab5t12
{
    internal class Program
    {
        static int writenum()
        {
            int number;
            do
            {
                Console.Write("Введите число от 1 до 100: ");
            } while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 100);

            Console.WriteLine("Введенное число: " + number);
            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(writenum());
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
