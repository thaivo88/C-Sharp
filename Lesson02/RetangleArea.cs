using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class RetangleArea
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Lesson02.Rectangle(10.0, 20.0);
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle: {0}", area);
        }
    }
}
