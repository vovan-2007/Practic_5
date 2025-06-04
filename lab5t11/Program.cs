namespace lab5t11
{
    internal class Program
    {
        static int Convert(int number, int numsys)
        {
            if (numsys < 2 || numsys > 10)
                Console.WriteLine("Система счисления должна быть от 2 до 10");
            bool minus = number < 0;
            number = Math.Abs(number);
            int result = 0;
            int pow = 1;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit >= numsys)
                    Console.WriteLine($"Некорректная цифра {digit} для основания {numsys}");

                result += digit * pow;
                pow *= numsys;
                number /= 10;
            }
            return minus ? -result : result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Convert(101011, 2));
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
