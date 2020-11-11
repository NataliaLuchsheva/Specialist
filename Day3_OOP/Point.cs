using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Point : GraphObject
    {
        private int X;
        public int Y;
     
        public Point(int X, int Y, string Color = DEFAULT_COLOR)
            :base (Color)
        {
            this.X = X;
            this.Y = Y;
        }

        // применение паттерна Fabrica. В scene не будут добавляться объекты в случае exeption
        public static Point create(int X, int Y, string Color = DEFAULT_COLOR)
        {
            Point p = new Point(X, Y, Color);
            GraphObject.scene.Add(p); 
            return p;
        }

        public void MoveBy(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public override void Draw()
        {
             Console.WriteLine($"Point ({X}, {Y}). {Color}");
        }
    }
}
