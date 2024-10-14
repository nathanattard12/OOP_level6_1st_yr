using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Ploymorphism
{
    public class Circle : Point
    {
        // Circle > Point. double radius; findPerimiter , findarea()
        double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

     

        public virtual double findPerimitter()
        {
            return Math.PI * Radius * 2;
        }

        public virtual double findArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }   
}
