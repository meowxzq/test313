using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int x1 = random.Next(1, 10);
            int y1 = random.Next(1, 10);
            int x2 = random.Next(1, 10);
            int y2 = random.Next(1, 10);
            Console.WriteLine($"Первая точка: ({x1}, {y1})");
            Console.WriteLine($"Вторая точка: ({x2}, {y2})");
            double distance = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            Console.WriteLine($"Расстояние между точками: {distance}");
            Console.ReadLine();
            double circumference = 2 * Math.PI * distance;
            Console.WriteLine($"Длина окуржности с радиусом {distance}: {circumference})");
        }
    }
}
