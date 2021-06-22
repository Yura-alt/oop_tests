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
        public Point BasePoint { get; set; } // основаная точка отрисовки фигур
        public string Name { get; set; }
        public  Color Color { get; set; }

        public abstract void Draw(ref Canvas myCanvas);


//        1. Shape.Draw убрать лишние аргументы(shape, BasePoint) и сделай его абстрактным;
//2. Что-то странное происходит при очистке по правой кнопке(объекты медленно появляются);
//3. Мне нужно было чтобы ты настроил таймер на несколько миллисекунд и постоянно перерисовывал все примитивы(очистил экран, нарисовал все заново);
    }
}
