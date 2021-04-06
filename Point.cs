using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    class Point
    {
        public int X { get; }
        public int Y { get; }
        public string pointName { get; }

        public Point(int xCor, int yCor, string pName) //Конструктор
        {
            X = xCor;
            Y = yCor;
            pointName = pName;
        }     
    }  
}
