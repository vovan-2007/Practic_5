namespace lab5t10
{
    internal class Program
    {
        static string Convert(int number, int numsys)
        {
            if (numsys < 2 || numsys > 10)
                Console.WriteLine("Система счисления должна быть в пределах от 2 до 10");

            if (number == 0) return "0";

            string res = "";
            bool minus = number < 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int mod = number % numsys;
                res = mod + res;
                number /= numsys;
            }

            return minus ? "-" + res : res;
        }
        static void Main(string[] args)
        {
            Convert(101, 2);
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
