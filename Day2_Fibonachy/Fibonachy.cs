using System;

namespace Day2_Fibonachy
{
    class Fibonachy
    {
        static void Main(string[] args)
        {
            int a = 1, nx = a, pr = a;

            while (nx < 1000)
            {
                Console.WriteLine ($"nx: {nx}");
               
                a = pr;
                pr = nx;
                nx = pr + a;
             //   Console.ReadLine();

            }
        }
    }
}
