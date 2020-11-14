using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{

    public abstract class GraphObject
    {
        public const string DEFAULT_COLOR = "black";

        public string color;

        protected static List<GraphObject> scene = new List<GraphObject>();
        public string Color;

        public abstract string Shape { get; }

        public static void DrawScene()
        {
            //foreach (Graphobject g in scene)
            foreach (var g in scene)
                g.Draw();
        }

        public GraphObject(string Color = DEFAULT_COLOR)
        {
            this.Color = Color;
        }

        public virtual void Draw()
        {
            Console.WriteLine("GraphObject. {0}", this.Color);
        }
    }
}
