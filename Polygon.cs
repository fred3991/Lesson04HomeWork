using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    class Polygon
    {
        // должно ли быть поле у полигона - периметр?
        public Polygon(List<Point> pointList) //конструктор по умолчанию
        {

        }

        public double Perimeter(List<Point> pointList)
        {
            double perimeterValue = 0; // инициализируем переменную

            int pointCount = pointList.Count; // количество точек

            List<double> lenghtArray = new List<double>() ; // массив с длинами точек

            // расчитываем длину от 1 до 2 точки...

            double d, lastLenght;

            for (int i = 0; i< pointCount-1; i++) // считаем длины сторон многоугольника с первой до последней
            {
                d = Math.Sqrt(Math.Pow((pointList[i+1].X - pointList[i].X), 2) + Math.Pow((pointList[i+1].Y - pointList[i].Y), 2));
                lenghtArray.Add(d);
            }
            //Считаем первую и последнюю точку
            lastLenght = Math.Sqrt(Math.Pow((pointList[pointCount-1].X - pointList[0].X), 2) + Math.Pow((pointList[pointCount-1].Y - pointList[0].Y), 2));

            lenghtArray.Add(lastLenght);
            perimeterValue = lenghtArray.Sum();
            return perimeterValue;
        }
    }
}
