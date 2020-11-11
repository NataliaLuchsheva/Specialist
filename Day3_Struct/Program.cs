using System;

namespace Day3_Struct
{
    class Program
    {
        struct Person
        {

            public string Name;
            public int? Age;

            // конструктор
            public Person(string Name, int? Age = null)
            {
                this.Name = Name;
                this.Age = Age;
            }

            public void Show()
            {
                if (Age == null)
                    Console.WriteLine(Name);
                else
                    Console.WriteLine("{0} - {1}", Name, Age);
            }

        }
        static void Main(string[] args)
        {
            Person pers1 = new Person("Матвей", 20);
            pers1.Show();

            Person pers2 = new Person("Лена", 30);
            pers2.Show();

            // проба примера
            Console.Write("Имя: ");
            Person p3;
            string name = Console.ReadLine();

            Console.Write("Возраст: ");
            int age;
            if (int.TryParse(Console.ReadLine(), out age))
                p3 = new Person(name, age);
            else
                p3 = new Person(name);

            p3.Show();
        }
    }
}
