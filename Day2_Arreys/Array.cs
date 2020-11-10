using System;

namespace Day2_Arreys
{
    class Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер будущего массива:");
            int r = int.Parse(Console.ReadLine());

            if (r <= 0)
            { 
                Console.WriteLine("Размер некорректный");
                return;
            }

            int[] arr = new int[r];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите {0} элемент (число) :", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // сортировка и суммирование всех элементов
            int temp;
            int summ = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        summ += temp;
                    }
                }
            }

            Console.WriteLine("Максимальный элемент: {0}", arr[^1]);
            Console.WriteLine("Минимальный элемент: {0}", arr[0]);

            Double avgRes= summ / r;
            Console.WriteLine("Среднее значение элементов: {0:F3}", avgRes);


        }
    }
}



 