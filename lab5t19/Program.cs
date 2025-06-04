
namespace lab5t19
{
    internal class Program
    {
        static (double position, double totalDistance) ManPosition(int N)
        {
            double position = 0;
            double totalDistance = 0;

            for (int step = 1; step <= N; step++)
            {
                double distance = 1.0 / step;
                totalDistance += distance;

                if (step % 2 == 1)
                    position += distance; 
                else
                    position -= distance; 
            }

            position = Math.Max(0, Math.Min(1, position));
            return (position, totalDistance);
        }

        static void Main()
        {
            Console.Write("Введите количество этапов N: ");
            int N = int.Parse(Console.ReadLine());

            var result = ManPosition(N);
            Console.WriteLine($"После {N} этапов:");
            Console.WriteLine($"a) Позиция: {result.position:F4} км от дома");
            Console.WriteLine($"б) Общий путь: {result.totalDistance:F4} км");
            Console.WriteLine("Нажмите любую клвашишу для завершения...");
            Console.ReadKey();
        }
    }
}
