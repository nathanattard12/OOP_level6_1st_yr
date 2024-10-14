using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Ploymorphism
{
    public class Sphere : Circle
    {

        int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        // * 3D Sphere > Circle. int z; FindPerimiter(), FindArea

        public override double findPerimitter()
        {
            return base.findPerimitter();
        }

        public override double findArea()
        {
            return 4 * base.findArea();
        }

        public virtual double FindVolume()
        {
            return (4 / 3) * (Math.PI * Math.Pow(Radius, 3));
        }
    }
}
