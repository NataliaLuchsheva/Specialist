using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Circle : GraphObject
    {
        public int X;
        public int Y;
        public int R;

        public Circle(int X, int Y, int R, string Color = DEFAULT_COLOR)
            : base (Color)
        {
            this.X = X;
            this.Y = Y;
            this.R = R;
        }

        // применение паттерна Fabrica. В scene не будут добавляться объекты в случае exeption
        public static Circle create(int X, int Y, int R, string Color = DEFAULT_COLOR)
        {
            Circle p = new Circle(X, Y, R, Color);
            GraphObject.scene.Add(p);
            return p;
        }
        // масштабирование
        public void Scale(double factor)
        {
            R = (int)(factor * R);
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle ({X}, {Y}). R: {R}. {Color}");
        }

        public static explicit /*implicit*/ operator Point(Circle c)
        {
            return new Point(c.X, c.Y);
        }


    }
}
