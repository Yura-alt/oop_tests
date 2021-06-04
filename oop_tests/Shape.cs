using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace oop_tests
{
    class Shape : System.Windows.Shapes.Shape
    {

        public Point[] PointCoordinate = new Point[5];  // координаты точек для всех фигур кроме круга


        public static Point BasePoint { get; set; } // основаная точка отрисовки фигур
        public string Name { get; set; }

       
        public  Color Color { get; set; }

        public System.Windows.Shapes.Shape RandomShape { get; set; }

        protected override Geometry DefiningGeometry => throw new NotImplementedException(); // эту штуку студио сама предлажила когда я унаследовался от System.Windows.Shapes.Shape

        public Shape()
        {

        }


       
        public virtual void Draw(Shape shape, ref Canvas myCanvas, Point BasePoint)
        {
            SolidColorBrush brush = new SolidColorBrush(Color);
            Polygon polygon = new Polygon
            {
                Stroke = brush,
                StrokeThickness = 1,

            };

            polygon.Points.Add(BasePoint); // добавляем сначал  основную точку потом остальные 
            for (int i = 1; i < shape.PointCoordinate.Length; i++)
            {
                if (shape.PointCoordinate[i].X == 0 & shape.PointCoordinate[i].Y ==0)
                {
                    break;
                }
                polygon.Points.Add(shape.PointCoordinate[i]);
                
            }
            shape.RandomShape = polygon;


            myCanvas.Children.Add(shape.RandomShape);
        }
    }
}
