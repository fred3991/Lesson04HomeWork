using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    class Vector
    {
        public double X;
        public double Y;
        public double Z;

        public Vector(double X, double Y, double Z) // Конструктор
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        // Длина вектора
        /// <summary>
        /// Возвращает длину вектора
        /// </summary>
        /// <returns></returns>
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        // Скалярное произведение с другим вектором


        /// <summary>
        /// Скалярное произведение с другим вектором
        /// </summary>
        /// <param name="vectorB"></param>
        /// <returns></returns>
        public double ScalarProduct(Vector vectorB)
        {
            return (X*vectorB.X)+(Y*vectorB.Y)+(Z*vectorB.Z); // возвращает число - скаляр
        }

        //
        /// <summary>
        /// Mетод, вычисляющий векторное произведение с другим вектором
        /// </summary>
        /// <param name="vectorB"></param>
        /// <returns></returns>
        public Vector СrossProduct(Vector vectorB)  // Возвращает новый век тор
        {
            double newVecX, newVecY, newVecZ;
            newVecX = (Y * vectorB.Z - Z * vectorB.Y);
            newVecY = (Z * vectorB.X - X * vectorB.Z);
            newVecZ = (X * vectorB.Y - Y * vectorB.X);

            return new Vector(newVecX, newVecY, newVecZ);
        }

        // Косинус между двумя векторами
        /// <summary>
        /// Косинус между двумя векторами
        /// </summary>
        /// <param name="vectorB"></param>
        /// <returns></returns>
        public double CosineOfVector(Vector vectorB)
        {
            double lenVectorA = Length();
            double lenVectorB = vectorB.Length();

            double scalarProduct = ScalarProduct(vectorB);

            return (scalarProduct) / (lenVectorA * lenVectorB);
        }


        // Сумма двух векторов является вектором
        public Vector SumVector(Vector vectorB)
        {
            double newX, newY, newZ;

            newX = X + vectorB.X;
            newY = Y + vectorB.Y;
            newZ = Z + vectorB.Z;

            Vector sumVector = new Vector(newX, newY, newZ);

            return sumVector;
        }

        // Сумма двух векторов является вектором
        public Vector MinusVector(Vector vectorB)
        {
            double newX, newY, newZ;

            newX = X - vectorB.X;
            newY = Y - vectorB.Y;
            newZ = Z - vectorB.Z;

            Vector minusVector = new Vector(newX, newY, newZ);

            return minusVector;
        }
    }
}
