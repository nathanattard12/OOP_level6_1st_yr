using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Ploymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Show the user the menu CREATE SHAPE 2. Find per 3.Find area 4.FInd volumee
            //if user == 1 another menu to  choose to create a circle sphere or sylinder
            // you add the shape to list
            //get back to main menu
            //if then the user chooses find perminter, all perimters of all shapes in list most be shown on screen
            //depneding on what the user shape choose ank for detailss

            List<Circle> list = new List<Circle>();
            int choice = 0;

            do
            {

            
            Console.WriteLine("1. Add a shape");
            Console.WriteLine("2. Find perimeters");
            Console.WriteLine("3. Find areas");
            Console.WriteLine("4. Find volumes");
            Console.WriteLine("5. Quit");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1. Circle");
                        Console.WriteLine("2. Sphere");
                        Console.WriteLine("3. Cylinder");
                        int choice2 = Convert.ToInt32(Console.ReadLine());

                        switch (choice2)
                        {
                            case 1: //Input details for a circle
                                Circle myCircle = new Circle();
                                Console.WriteLine("input X");
                                myCircle.X = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input Y");
                                myCircle.Y = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input Z");
                                myCircle.Radius = Convert.ToInt32(Console.ReadLine());

                                list.Add(myCircle); // you can add a circle into a List<Point> becasue circle is a point

                                //user is redirected to the main menu
                                break;

                            case 2: //Input details for a Sphere

                                Sphere mySphere = new Sphere();
                                Console.WriteLine("input X");
                                mySphere.X = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input Y");
                                mySphere.Y = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input Z");
                                mySphere.Z = Convert.ToInt32(Console.ReadLine());
                                    
                                list.Add(mySphere); // you can add a circle into a List<Point> becasue circle is a point

                                break;


                            case 3: //Input details for a Cylidner
                                Cylinder myCylinder = new Cylinder();
                                Console.WriteLine("input X");
                                myCylinder.X = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input Y");
                                myCylinder.Y = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input Radius");
                                myCylinder.Radius = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input Height");
                                myCylinder.Height = Convert.ToInt32(Console.ReadLine());

                                list.Add(myCylinder); // you can add a circle into a List<Point> becasue circle is a point
                                break;
                        }
                        break;

                    case 2: // Find the parameter
                        //for while , do-while,foreach
                        foreach (var shape in list)
                        {
                            Console.WriteLine($"Perimiter for {shape.GetType().Name} with radius {shape.Radius} Is: {shape.findPerimitter()}\n");
                        }
                        Console.WriteLine("Hit a key to get back to the main menu");
                        Console.ReadLine();
                        break;

                    case 3:
                        foreach (var shape in list)
                        {
                            Console.WriteLine($"Area for {shape.GetType().Name} with radius {shape.Radius} Is: {shape.findArea()}\n");
                        }
                        Console.WriteLine("Hit a key to get back to the main menu");
                        Console.ReadLine();
                        break;

                    case 4:
                        //todo: FIX THIS !----------------------------------------
                        foreach (var shape in list)
                        {
                            if (shape.GetType() == typeof(Circle))
                            {
                                //only circles get in here
                                Console.WriteLine("Volume of circle cannot be calculated");
                            } else
                            {
                                //only Spheres and cylinders will get in here
                                //data type of shape will always be circle
                                //...so we need conversionto be ableto call the FindVolume
                                //why did i choose sphere?

                                Sphere s = (Sphere) shape; //! typecasting //implicit conversion
                                Console.WriteLine($"vOLUME for {s.GetType().Name} with radius {s.Radius} Is: {s.FindVolume()}\n");

                            }

                        }
                        Console.WriteLine("Hit a key to get back to the main menu");
                        Console.ReadLine();
                        break;

                    case 5:
                        break;
                }

            } while (choice != 5);

            Console.WriteLine("Hit a key to continue");
            Console.ReadKey();
        }
    }
}
