using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04HomeWork
{
    public abstract class Shape  // Мож
    {      
        private double volume; // инкапсуляция
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public abstract double GetVolume(); // абстрактный метод volume
    }
}


