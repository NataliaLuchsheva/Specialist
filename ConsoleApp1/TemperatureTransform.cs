using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TemperatureTransform
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру (С): ");

            Double tem1 = Double.Parse (Console.ReadLine());

            Double tem2 = tem1 * 9 / 5 + 32;
            Console.WriteLine("Введенная температура переведена в градусы F: {0:F2}", tem2);

        }
    }
}
