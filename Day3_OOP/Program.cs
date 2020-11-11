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

            Circle c1 = Circle.create(5, 6, 100, "red");

            c1.Scale(2);
            GraphObject.DrawScene();


        }
    }
}
