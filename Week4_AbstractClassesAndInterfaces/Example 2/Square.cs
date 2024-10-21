using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces.Example_2
{
    internal class Square : Shape
    {
        public override double FindArea()
        {
            return Length * Length;
        }

        public override double FindPerimiter()
        {
            return (Length + Length) * 2;
        }
    }

  
}
