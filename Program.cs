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
        }
    }
}
