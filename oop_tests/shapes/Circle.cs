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
    class Circle : Shape
    {
        public int Heght;
        public int Weight;

        public  Circle()
        {
           
        }

        public Circle(string name, Color colors,  int height, int weight, Point p)
        {
            Color = colors;
            Name = name;
            Heght = height;
            Weight = weight;

            BasePoint = p;
        }
        public override void Draw( ref Canvas myCanvas)
        {
            SolidColorBrush brush = new SolidColorBrush(Color);
            Ellipse ellipse = new Ellipse
            {
                Stroke = brush,
                StrokeThickness = 1,
                Height = Heght,
                Width = Heght,

            };
           
           // BasePoint = point;
            Canvas.SetLeft(ellipse, BasePoint.X - ellipse.Height / 2);
            Canvas.SetTop(ellipse, BasePoint.Y - ellipse.Height / 2);
            myCanvas.Children.Add(ellipse); 
        }

    }
}
