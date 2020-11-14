using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Point : GraphObject
    {

    // auto property
    public int X { get; set; } = 100;

        public int Y { get; set; }

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return X;
                    case 1: return Y;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: X = value; break;
                    case 1: X = value; break;
                    default: throw new IndexOutOfRangeException();
                }

            }

        }
        public int this[string index]
        {
            get
            {
                switch (char.ToUpper(index[0]))
                {
                    case 'X': return X;
                    case 'Y': return Y;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (char.ToUpper(index[0]))
                {
                    case 'X': X = value; break;
                    case 'Y': X = value; break;
                    default: throw new IndexOutOfRangeException();
                }

            }

        }

        public override string Shape
        {
            get
            {
                return "Точка";
            }
        }


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
