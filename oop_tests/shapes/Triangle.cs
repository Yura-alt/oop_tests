using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace oop_tests.shapes
{
    class Triangl :Shape
    {

        public Triangl()
        {

        }

        public Triangl(string name, Color colors, params int[] kor)
        {
            Color = colors;
            Name = name;
            int i = 0;
            foreach (var item in kor)
            {
                if (i % 2 == 0)
                {
                    PointCoordinate[i / 2].X = item;
                }
                else
                {
                    PointCoordinate[i / 2].Y = item;
                }
                
                i++;
            }
        }

        public override void Draw(Shape shape, ref Canvas myCanvas, Point BasePoint)
        {

            base.Draw(shape, ref myCanvas, BasePoint);
        }
    }
}
