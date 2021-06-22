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
     abstract class Shape
    {
        public Point BasePoint { get; set; } 
        public string Name { get; set; }
        public  Color Color { get; set; }

        public abstract void Draw(ref Canvas myCanvas);


    }
}
