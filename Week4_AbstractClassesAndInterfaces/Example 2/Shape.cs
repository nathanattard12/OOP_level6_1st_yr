using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces.Example_2
{
    public abstract class Shape : I2DCalculations, IShape
    {
       
        public double Length { get; set; }
        public abstract double FindArea();

        public abstract double FindPerimiter();

        string IShape.Print()
        {
            return $"Shape has a length of : {Length}";
        }
    }
}
