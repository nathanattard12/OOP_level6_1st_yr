using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces.Example_2
{
    internal class Rectangle : Square
    {
        public double Width { get; set; }

        public override double FindArea()
        {
            return Length * Width;
        }

        public override double FindPerimiter()
        {
            return (Length + Width) * 2;
        }
    }
}
