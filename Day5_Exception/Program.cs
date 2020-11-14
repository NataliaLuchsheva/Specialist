using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP
{

    class Program
    {

        static void Main(string[] args)
        {
            Point p1 = Point.create(10, 20, "green");

            //Circle c1 = Circle.create(5, 6, -100, "red");

            try
            {
                // используем фабричный метод
                Circle c1 = Circle.Create(100, 200, -50);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //c1.Scale(2);
            GraphObject.DrawScene();


        }
    }
}
