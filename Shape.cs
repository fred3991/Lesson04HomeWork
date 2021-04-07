using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    abstract class Shape
    {
        public double volume;
        //public Shape() //Конструктор по умолчанию
        //{
        //
        public abstract double Volume(); // абстрактный метод volume
    }




    class Cylinder : Shape
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

    class Pyramid : Shape
    {
        public double area;
        public double height;

        public Pyramid(double area, double height)
        {
            this.area = area;
            this.height = height;
            volume = Volume();
        }

        public override double Volume()
        {
            return volume=(area*height)/3.0; // возвращает обьем фигуры
        }
    }

    class Ball : Shape
    {
        public double radius;
        
        
        public Ball(double radius)
        {
            this.radius = radius;
            volume = Volume();
        }
        public override double Volume()
        {
            return (4.0/3.0) * Math.PI * (radius * radius * radius); // возвращает обьем фигуры
        }
    }




    // <summary>
    /// Класс коробка,
    /// имеет обьем, и список того что внутри.
    /// Имеет метод Add (Shape shape) - который выдает true если можно поместить внутрь еще один обьект
    /// или False если обьем будет превышен
    // </summary>
    // 
    class Box : Shape
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
        public override double Volume()
        {
            return volume=Math.Pow(H, 3); // Возвращает обьем коробки
        }


        public double BoxFreeSpace()
        {
            double vol = volume;
            if (shapeList != null)
            {
                foreach (Shape sh in shapeList)
                {
                    vol = vol-sh.volume;
                }
            }       
            return vol;
        }
        



        public bool Add(Shape shape)
        {
            bool emptyspace;
           
                if(shape.volume<(boxFreeSpace))
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


