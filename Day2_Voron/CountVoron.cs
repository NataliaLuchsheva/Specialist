using System;

namespace Day2_Voron
{
    class Voron
    {
        static void Main(string[] args)
        {

                Console.Write("Введите количество ворон: ");
                int countV = int.Parse(Console.ReadLine());

                string StrV;

                switch (countV % 10)
                {
                case 1: 
                    StrV = "ворона"; break;
                case 2:
                case 3:
                case 4: 
                    StrV = "вороны"; break;
                default: 
                    StrV = "ворон"; break;
                }

                string result = $"На ветке {countV} {StrV}";

                Console.WriteLine(result);
            }
        }
    }

