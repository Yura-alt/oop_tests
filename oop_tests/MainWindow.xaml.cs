using oop_tests.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace oop_tests
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.Children.Clear();


            Point point = new Point();

            point.X = (int)e.GetPosition(null).X; 
            point.Y = (int)e.GetPosition(null).Y;

            Shape.BasePoint = point;


            Circle circle = new Circle("Круг", Colors.DarkGray, 100, 100);

            Rectangl rectangle = new Rectangl("Прямоугольник", Colors.Red, 100, 200);

            Triangl triangle = new Triangl("Треугольник", Colors.Blue, 0, 0, 250, 400, 100, 300);

            Random rnd = new Random();

            int caseSwitch = rnd.Next(0, 3);

            switch (caseSwitch)
            {
                case 1:
                    triangle.Draw(triangle, ref myCanvas, point);
                    break;
                case 2:
                    circle.Draw(circle, ref myCanvas, point);
                    break;
                default:
                    rectangle.Draw(rectangle, ref myCanvas, point);
                    break;
            }
        }

        private void MyCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.Children.Clear();


            Point point = new Point();

            point.X = (int)e.GetPosition(null).X - 10; // Почему то происходит смещение относительно указателя мыши и оси х
            point.Y = (int)e.GetPosition(null).Y;

            Shape.BasePoint = point;


            Circle circle = new Circle("Круг", Colors.DarkGray, 100, 100);

            Rectangl rectangle = new Rectangl("Прямоугольник", Colors.Red, 100, 200);

            Triangl triangle = new Triangl("Треугольник", Colors.Blue, 0, 0, 250, 400, 100, 300);

            Random rnd = new Random();

            int caseSwitch = rnd.Next(0, 3);

            switch (caseSwitch)
            {
                case 1:
                    triangle.Draw(triangle, ref myCanvas, point);
                    break;
                case 2:
                    circle.Draw(circle, ref myCanvas, point);
                    break;
                default:
                    rectangle.Draw(rectangle, ref myCanvas, point);
                    break;
            }
        } // событие обработки на холсте не срабатывают 
    }
}
