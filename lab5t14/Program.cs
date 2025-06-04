namespace lab5t14
{
    internal class Program
    {
        static double avg()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Введите оценку по предмету {i}: ");
                sum += int.Parse(Console.ReadLine());
            }
            return sum / 10.0;
        }
        static void Main(string[] args)
        {
            avg();
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
