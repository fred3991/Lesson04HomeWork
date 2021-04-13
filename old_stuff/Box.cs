using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    // <summary>
    /// Класс коробка,
    /// имеет обьем, и список того что внутри.
    /// Имеет метод Add (Shape shape) - который выдает true если можно поместить внутрь еще один обьект
    /// или False если обьем будет превышен
    // </summary>
    // 
    public class Box : Shape
    {
        // Высота ребра коробки
        public double boxFreeSpace { get => BoxFreeSpace(); }
        public double H;
        public List<Shape> shapeList;

        public Box(double H)
        {
            this.H = H;
            volume = Volume();
            shapeList = new List<Shape>();
        }

        //Обьем коробки
        public override double GetVolume()
        {
            return volume = Math.Pow(H, 3); // Возвращает обьем коробки
        }


        public double BoxFreeSpace()
        {
            double vol = volume;
            if (shapeList != null)
            {
                foreach (Shape sh in shapeList)
                {
                    vol = vol - sh.volume;
                }
            }
            return vol;
        }




        public bool Add(Shape shape)
        {
            bool emptyspace;

            if (shape.volume < (boxFreeSpace))
            {
                shapeList.Add(shape);
                emptyspace = true;
            }
            else
            {
                emptyspace = false;
            }

            return emptyspace;
        }

    }
}
