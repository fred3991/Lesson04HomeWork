using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    public class Cylinder : Shape
    {
        public double radius;
        public double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
            volume = Volume();
        }

        public override double Volume()
        {
            return volume = Math.PI * radius * radius * height; // возвращает обьем фигуры
        }
    }
}
