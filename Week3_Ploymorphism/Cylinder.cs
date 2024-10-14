using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Ploymorphism
{
    public class Cylinder: Circle
    {
        // * Cylinder > Cirlce. int z double height; FindPerimiter, FindArea()

        double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

      



        public override double findPerimitter()
        {
            return 2*(2*Radius) + Height;
        }

        public override double findArea()
        {
            return (2 * Math.PI*Radius*Height) + (2*Math.PI*Radius*Radius);
        }

        public virtual double FindVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }



    }
}
