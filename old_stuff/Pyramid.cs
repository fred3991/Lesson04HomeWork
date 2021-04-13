using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    public class Pyramid : Shape
    {
        public double area;
        public double height;

        public Pyramid(double area, double height)
        {
            this.area = area;
            this.height = height;
            volume = Volume();
        }

        public override double GetVolume()
        {
            return volume = (area * height) / 3.0; // возвращает обьем фигуры
        }
    }
}
