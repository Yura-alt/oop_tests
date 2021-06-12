using oop_tests.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace oop_tests
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Shape> shapesList = new List<Shape>();

        DispatcherTimer timerW = new DispatcherTimer();
        int tic = 0;


        public MainWindow()
        {
            InitializeComponent();
            timerW.Tick += new EventHandler(TimerW_Tick);
            timerW.Interval = new TimeSpan(0, 0, 1);

        }

        private void TimerW_Tick(object sender, EventArgs e)
        {
            if (shapesList.Count() == tic)
            {
                tic = 0;
                timerW.Stop();
            } 
            shapesList[tic].Draw(shapesList[tic], ref myCanvas, shapesList[tic].BasePoint);
            tic++;
        }


        private void MyCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.Children.Clear();


            Point point = new Point();

            point.X = (int)e.GetPosition(null).X - 10; // Почему то происходит смещение относительно указателя мыши и оси х
            point.Y = (int)e.GetPosition(null).Y;

            // Shape.BasePoint = point;


            Circle circle = new Circle("Круг", Colors.DarkGray, 100, 100);

            Rectangl rectangle = new Rectangl("Прямоугольник", Colors.Red, point, 100, 200);

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

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.Children.Clear();
            if (shapesList.Count() > 0)
                timerW.Start();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int canvasWeight = (int)myCanvas.ActualWidth;
            int canvasHeight = (int)myCanvas.ActualHeight;

            Point point = new Point
            {
                X = (int)e.GetPosition(null).X,
                Y = (int)e.GetPosition(null).Y
            };

            Random rnd = new Random();

            Circle circle = new Circle("Круг", Colors.DarkGray, rnd.Next(10, canvasWeight - (int)point.X), rnd.Next(10, canvasHeight - (int)point.Y));
            Rectangl rectangle = new Rectangl("Прямоугольник", Colors.Red, point, rnd.Next(10, canvasWeight - (int)point.X), rnd.Next(10, canvasHeight - (int)point.Y));
            Triangl triangle = new Triangl("Треугольник", Colors.Blue, (int)point.X, (int)point.Y, rnd.Next(10, canvasWeight - (int)point.X), rnd.Next(10, canvasHeight - (int)point.Y), rnd.Next(10, canvasWeight - (int)point.X), rnd.Next(10, canvasHeight - (int)point.Y));

            int caseSwitch = rnd.Next(0, 3);
            switch (caseSwitch)
            {
                case 1:
                    triangle.Draw(triangle, ref myCanvas, point);
                    shapesList.Add(triangle);
                    break;
                case 2:
                    circle.Draw(circle, ref myCanvas, point);
                    shapesList.Add(circle);
                    break;
                default:
                    rectangle.Draw(rectangle, ref myCanvas, point);
                    shapesList.Add(rectangle);
                    break;
            }
        }
    }
}
