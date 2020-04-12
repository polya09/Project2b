using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b
{
    class Cone : Circle
    {
        private double height;
        public double Height { get => height; set => height = value; }
        public Cone(double Radius, double height) : base(Radius)
        {
            Height = height;
        }
        public Cone() : base(0)
        {

        }
        public override string ToString()
        {
            return "R = " + Radius + "  H = " + Height + "   V = " + (0.3 * PI * Radius * Radius * Height);
        }
    }
}
