using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Ploymorphism
{
    
    //An abstract class allows you to implement partially some memebers within
    //in the below example properties can be implemented
    //but the methods we have to postpone the implementation to the inheriting classes
    public class Point
    {
        /* 
         * You need 3 classes
         * 
         * Point > int x , int y
         * Circle > Point. double radius; findPerimiter , findarea()
         * 3D Sphere > Circle. int z; FindPerimiter(), FindArea
         * 3D cylinder > sPHERE. int z, double height; FindPerimiter(), FindArea(),Find volume
         
         */
        
        int x;
        int y;

        public int X
        {  
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        
     
        
    }
}
