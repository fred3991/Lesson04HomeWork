using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    public class Ball : Shape
    {
        public double radius;
        public Ball(double radius)
        {
            this.radius = radius;
            volume = Volume();
        }
        public override double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * (radius * radius * radius); // возвращает обьем фигуры
        }
    }
}
