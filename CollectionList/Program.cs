using System;
using System.Collections.Generic;

namespace CollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> persons = new List<string>();
            int num = 0;
            
            while (true)
            {
                num++;
                Console.Write("Введите имя {0}: ", num);
                string name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    persons.Add(name);
                else
                    break;
            }

            persons.Sort();

            foreach (string name in persons)
                Console.WriteLine(name);
        }
    }
}
