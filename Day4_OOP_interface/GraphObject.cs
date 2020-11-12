using System;
using System.Collections.Generic;
using System.Text;

/*
 * 1.Создать интерфейс IColorfull и метод  setColor, передающий цвет
 * Реализовать интерфейс, чтоб в GraphObject менялся цвет
 * 2. Сделать метод, альтернативный ScaleScene, ColorScene, который красит все объекты в один цвет
 * Потом перебирает все цвета и проверяет, реализован ли объект граф. инт., и, если реализован, то красит
 */

namespace OOP
{

    public abstract class GraphObject : IColorFull
    {
        public const string DEFAULT_COLOR = "black";

        public string color;

        protected static List<GraphObject> scene = new List<GraphObject>();
        public string Color;

        public static void DrawScene()
        {
            //foreach (Graphobject g in scene)
            foreach (var g in scene)
                g.Draw();
        }

        public static void ScaleScene(string color)
        {
            foreach (GraphObject g in scene)
            {
                if (g is IColorFull)
                {
                    (g as IColorFull).SetColor(color);
                }
            }
        }

        public GraphObject(string Color = DEFAULT_COLOR)
        {
            this.Color = Color;
        }

        public virtual void Draw()
        {
            Console.WriteLine("GraphObject. {0}", this.Color);
        }

        void IColorFull.SetColor(string color)
        {
            this.Color = color;
        }
    }
}
