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
        public int Heght;
        public int Weight;

        public Point[] PointCoordinate = new Point[4];

        public Rectangl()
        {
           
        }

        public Rectangl(string name, Color colors, Point BasePoint , int weight, int height)
        {
            Color = colors;
            Name = name;
            Heght = height;
            Weight = weight;

            PointCoordinate[0].X = BasePoint.X;
            PointCoordinate[0].Y = BasePoint.Y;

            PointCoordinate[1].X = BasePoint.X - weight;
            PointCoordinate[1].Y = BasePoint.Y;

            PointCoordinate[2].X = BasePoint.X - weight;
            PointCoordinate[2].Y = BasePoint.Y - height;

            PointCoordinate[3].X = BasePoint.X;
            PointCoordinate[3].Y = BasePoint.Y - height;
        }

        public override void Draw(Shape shape, ref Canvas myCanvas, Point BasePoint)
        {
            SolidColorBrush brush = new SolidColorBrush(Color);
            Polygon polygon = new Polygon()
            {
                Stroke = brush,
                StrokeThickness = 1,

            };

            for (int i = 0; i < PointCoordinate.Length; i++)
                polygon.Points.Add(PointCoordinate[i]);

            this.BasePoint = BasePoint;
            myCanvas.Children.Add(polygon);
        }
    }
}
