using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b
{
    class Circles
    {
        Circle[] circles;
        int lastCircleNumber;

        public Circle GetCircleAt(int i)
        {
            return circles[i];
        }
        public Circles()
        {
            circles = new Circle[0];
            lastCircleNumber = -1;
        }
        public Circles(int N)
        {
            circles = new Circle[N];
            lastCircleNumber = -1;
        }

        public int getCirclesNumber()
        {
            return circles.Length;
        }
        public bool addCircle(Circle circle)
        {
            if (lastCircleNumber+1 < circles.Length)
            {
                circles[++lastCircleNumber] = circle;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            String result = "";
            for (int i = 0; i < circles.Length; i++)
            {
                result += circles[i].ToString() + Environment.NewLine;
            }
            return result;
        }
    }
}
