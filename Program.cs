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
            /// Но это уже все нарушает принцип YAGNI, в тз не было задания на проверку


            // Задание 2
            //Проектирование и создание класса, описывающего вектор
            //Создаем вектора
            Vector tstVector1 = new Vector(15, 13, -5);
            Vector tstVector2 = new Vector(3, 5, 45);


            Console.WriteLine("Тестовый вектор ");       
            Console.WriteLine($"Вектора {tstVector1.X} , {tstVector1.Y},  {tstVector1.Z}");
            double vectorLength = tstVector1.Length();
            Console.WriteLine("Длина вектора = " + vectorLength);
            Console.ReadLine();

            Console.WriteLine("Второй вектор ");      
            Console.WriteLine($"Вектора {tstVector2.X} , {tstVector2.Y},  {tstVector2.Z}");
            double scalarProduct = tstVector1.ScalarProduct(tstVector2);
            Console.WriteLine("Скалярное произведение векторов = " + scalarProduct);
            Console.ReadLine();

            //Mетод, вычисляющий векторное произведение с другим вектором - Результат вектор
            Vector crossProductVector = tstVector1.СrossProduct(tstVector2);
            Console.WriteLine("Векторное произведение векторов, новый вектор ");
            Console.WriteLine($"{crossProductVector.X}, {crossProductVector.Y}, {crossProductVector.Z}");
            Console.ReadLine();


            //Модуль вектора
            Console.WriteLine($"Модуль вектора(длина)  {crossProductVector.X},  {crossProductVector.Y},  {crossProductVector.Z}");
            double vectorModul = crossProductVector.Length();
            Console.WriteLine("Модуль вектора = " + vectorModul);

            Console.WriteLine($"Косинус угла между вектором  {tstVector1.X},  {tstVector1.Y},  {tstVector1.Z}");
            Console.WriteLine($"И");
            Console.WriteLine($"Вектором  {tstVector2.X},  {tstVector2.Y},  {tstVector2.Z}");
            double cos = tstVector1.CosineOfVector(tstVector2);
            Console.WriteLine("Косинус = " + cos);
            Console.WriteLine("В градусах = " + Math.Acos(cos)*(180/Math.PI));
            Console.ReadLine();


            //Сумма и разность между векторами
            Console.WriteLine($"Сумма и разность для вектора {tstVector1.X},  {tstVector1.Y},  {tstVector1.Z}");
            Console.WriteLine($"и {tstVector2.X},  {tstVector2.Y},  {tstVector2.Z}");
            Console.WriteLine($"Сумма = ({(tstVector1.SumVector(tstVector2)).X}, {(tstVector1.SumVector(tstVector2)).Y}, {(tstVector1.SumVector(tstVector2)).Z} )");
            Console.WriteLine($"Сумма = ({(tstVector1.MinusVector(tstVector2)).X}, {(tstVector1.MinusVector(tstVector2)).Y}, {(tstVector1.MinusVector(tstVector2)).Z} )");
            Console.ReadLine();
            Console.WriteLine("Конец");
            Console.ReadLine();
        }
    }
}
