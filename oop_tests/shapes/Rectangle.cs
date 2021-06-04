using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace oop_tests.shapes
{

    class Rectangl : Shape
    {

        public int Heght = 50;
        public int Weight = 50;

        public Rectangl()
        {

        }

        public Rectangl(string name, Color colors, int height, int weight)
        {
            Color = colors;
            Name = name;
            Heght = height;
            Weight = weight;

            PointCoordinate[1].X = BasePoint.X - weight;
            PointCoordinate[1].Y = BasePoint.Y;

            PointCoordinate[2].X = BasePoint.X - weight;
            PointCoordinate[2].Y = BasePoint.Y - height;

            PointCoordinate[3].X = BasePoint.X;
            PointCoordinate[3].Y = BasePoint.Y - height;

        }

        public override void Draw(Shape shape, ref Canvas myCanvas, Point BasePoint)
        {
            //myCanvas.Children.Add(rectangle);

            base.Draw(shape, ref myCanvas, BasePoint);
        }
    }
}
