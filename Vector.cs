using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    class Vector
    {
        private double X;
        private double Y;
        private double Z;

        public Vector(double X, double Y, double Z) // Конструктор
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        // Длина вектора
        public double Length(double X, double Y, double Z)
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        // Скалярное произведение с другим вектором
        public double DotProduct(Vector vectorA, Vector vectorB)
        {
            return (vectorA.X*vectorB.X)+(vectorA.Y*vectorB.Y)+(vectorA.Z* vectorB.X); // возвращает число - скаляр
        }

        //Mетод, вычисляющий векторное произведение с другим вектором
        public Vector СrossProduct(Vector vectorA, Vector vectorB)  // Возвращает новый век тор
        {
            double newVecX, newVecY, newVecZ;
            newVecX = (vectorA.Y * vectorB.Z - vectorA.Z * vectorB.Y);
            newVecY = (vectorA.Z * vectorB.X - vectorA.X * vectorB.Z);
            newVecZ = (vectorA.X * vectorB.Y - vectorA.Y * vectorB.X);

            return new Vector(newVecX, newVecY, newVecZ);
        }


    }



}
