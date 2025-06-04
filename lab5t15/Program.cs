namespace lab5t15
{
    internal class Program
    {
        static double CalculateAverageMass(int itemCnt)
        {
            

            double totalMass = 0;

            for (int i = 0; i < itemCnt; i++)
            {
                Console.Write($"Введите массу предмета {i + 1}: ");
                double mass;
                while (!double.TryParse(Console.ReadLine(), out mass) || mass <= 0)
                {
                    Console.Write("Ошибка! Введите положительное число: ");
                }
                totalMass += mass;
            }

            return totalMass / itemCnt;
        }

        static void Main()
        {
            Console.Write("Введите количество предметов: ");
            int count = Convert.ToInt32(Console.ReadLine);
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.Write("Ошибка! Введите целое число > 0: ");
            }

            double average = CalculateAverageMass(count);
            Console.WriteLine($"Средняя масса предметов: {average:F2} кг");
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
                Console.ReadKey();
            }
    }
}
