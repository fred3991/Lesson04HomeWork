using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задание 1 - Точка. Периметр полигона
            Point firstPoint = new Point(1,1, "firstPoint");
            Point secondPoint = new Point(2, 2, "secondPoint");
            Point threePoint = new Point(3, 1, "threePoint");
            Point fourPoint = new Point(2, -10, "fourPoint");
            Point fivePoint = new Point(-5, -5, "fivePoint");
            List<Point> pointList = new List<Point>();
            pointList.Add(firstPoint);
            pointList.Add(secondPoint);
            pointList.Add(threePoint);
            pointList.Add(fourPoint);
            pointList.Add(fivePoint);

            Polygon triangle = new Polygon(pointList);

            var p = triangle.Perimeter(pointList);

            Console.WriteLine("Периметр полигона = "+p);

            Console.ReadLine();
            /// Нету никаких проверок, возможно ли построить полигон по заданным точкам?
            /// Минимум должно быть 3 точки, для полигона,  - 3 точка не должна лежать на одной прямой с первыми двумя
            /// 4 и последующие точки тоже нужна проверка


            // Задание 2
            //2.Проектирование и создание класса, описывающего вектор

        }
    }
}
