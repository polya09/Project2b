using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b
{
    class Circle
    {

        private double radius;
        public const double PI = 3.14;

        public double Radius { get => radius; set => radius = value; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override string ToString()
        {

            return "R = " + this.radius + "   S = " + (PI * Radius * Radius) + "   C = " + (2 * PI * Radius);
        }
        public Circle Clone()
        {
            // Вызываем функцию базового класса (Object)
            // для поверхностного копирования объекта
            return (Circle)MemberwiseClone();
        }
        public void Write(BinaryWriter bw)
        {
            // Все данные записываются по отдельности
            bw.Write(radius);
        }
    }
    
}
