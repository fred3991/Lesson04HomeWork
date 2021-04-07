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
            Point firstPoint = new Point(1, 1, "firstPoint");
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

            Console.WriteLine("Периметр полигона = " + p);

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
            Console.WriteLine("В градусах = " + Math.Acos(cos) * (180 / Math.PI));
            Console.ReadLine();


            //Сумма и разность между векторами
            Console.WriteLine($"Сумма и разность для вектора {tstVector1.X},  {tstVector1.Y},  {tstVector1.Z}");
            Console.WriteLine($"и {tstVector2.X},  {tstVector2.Y},  {tstVector2.Z}");
            Console.WriteLine($"Сумма = ({(tstVector1.SumVector(tstVector2)).X}, {(tstVector1.SumVector(tstVector2)).Y}, {(tstVector1.SumVector(tstVector2)).Z} )");
            Console.WriteLine($"Разность = ({(tstVector1.MinusVector(tstVector2)).X}, {(tstVector1.MinusVector(tstVector2)).Y}, {(tstVector1.MinusVector(tstVector2)).Z} )");
            Console.ReadLine();
            Console.WriteLine("Конец");
            Console.ReadLine();


            ////////////////////////////////
            //
            //
            // Создаем обьемные фигуры
            Ball ball1 = new Ball(12);
            Ball ball2 = new Ball(32);
            Ball ball3 = new Ball(12);

            Pyramid pyr1 = new Pyramid(12, 18);
            Pyramid pyr2 = new Pyramid(33, 11);
            Pyramid pyr3 = new Pyramid(240, 30);

            Cylinder cyl1 = new Cylinder(30, 33);
            Cylinder cyl2 = new Cylinder(11, 99);
            Cylinder cyl3 = new Cylinder(120, 22);

            Console.WriteLine($"--------------------------------------------------------------------------");
            Console.WriteLine($"Создаем 9 фигур");
            Console.WriteLine($"3 шара с обьемом  - {ball1.volume}, {ball2.volume}, {ball3.volume} ");
            Console.WriteLine($"--------------------------------------------------------------------------");
            Console.WriteLine($"3 пирамиды с обьемом  - {pyr1.volume}, {pyr2.volume}, {pyr3.volume} ");
            Console.WriteLine($"--------------------------------------------------------------------------");
            Console.WriteLine($"3 цилиндра с обьемом - {cyl1.volume}, {cyl2.volume}, {cyl3.volume} ");
           

            Console.WriteLine($"--------------------------------------------------------------------------");
            Box box = new Box(100);

            Console.WriteLine($"Создали коробку с ребрами {box.H}");
            Console.WriteLine($"--------------------------------------------------------------------------");

            List<Shape> shapeList = new List<Shape>{ ball1, ball2, ball3, pyr1 , pyr2 , pyr3, cyl1, cyl2, cyl3 };


            Console.WriteLine($"Закидываем все фигуры в коробку и смотрим, залезли ли они туда?");

            bool loadNext = true;

            foreach(Shape sh in shapeList)
            {
                if (loadNext == box.Add(sh))
                {
                    Console.WriteLine($"--------------------------------------------------------------------------");
                    Console.WriteLine($"Предмет {sh.GetType()} c обьемом {sh.volume} Успешно положили в коробку! ");
                    Console.WriteLine($"В Коробке осталось {box.boxFreeSpace} пустого места!");
                    Console.WriteLine($"--------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"--------------------------------------------------------------------------");
                    Console.WriteLine($"В Коробке не хватает места для {sh.GetType()}, она обьемом {sh.volume}! А в коробке осталось только  {box.boxFreeSpace}!");
                    Console.WriteLine($"--------------------------------------------------------------------------");
                }
              
                
            }

            Console.WriteLine($"--------------Конец----------------");
            Console.ReadLine();

        }
    }
}
