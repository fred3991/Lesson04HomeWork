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

            



            /


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
