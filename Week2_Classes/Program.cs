using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(); //!a declaration and an intiarlization of Book at the same time/on the same line;
            Book myBook2; //!Declaration
            myBook2 = new Book(); //! Initilization becasue we are calling the constructer

            DateTime dt = new DateTime(2000,1,20);
            DateTime dt2 = new DateTime(2000,1,20,1,1,1);


            Book myBook3 = new Book("3456789"); //! this constroctor will assign immediant ly isbn into the field/property
            myBook2.Name = "Test";
            myBook2.Year = 2000;

            //! class: is allowing us to define the entity e.g. Book
            //! Object: is allowing us to personalize the book
            Book b; //! declaration of the obejct
            b = new Book(); //!initialization of the object (creation of memeory spacethat willl hold data about b)

            Console.WriteLine("Input a name for the book: ");
            b.Name =  Console.ReadLine();

            Console.WriteLine("Input a Isbn for the book: ");
            b.Isbn = Console.ReadLine();

            Console.WriteLine("Input the year for the book: ");
            try
            {
                b.Year = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Invalid Year Input.");
            }


            //! approach 1
            /*
                Console.WriteLine("1. Horror");
                Console.WriteLine("2. Fiction");
                Console.WriteLine("3. SciFi");
            */

            //! approach 2
            string[] namesInTheGenreSet =  Enum.GetNames(typeof(GenreType));

            for (int i= 0; i < namesInTheGenreSet.Length; i++)
            {
                Console.WriteLine($"{i+1}. {namesInTheGenreSet[i]}");
            }
            Console.WriteLine("Type the preffered genre number");
            b.Genre = (GenreType) Convert.ToInt32(Console.ReadLine());


            //! to show back whatever the user input on screen

            Console.WriteLine($"Name: {b.Name} , ISBN: {b.Isbn} , Year: {b.Year} Genre: {Enum.GetName(typeof(GenreType),b.Genre)}" + 
                $"\n Book is {b.HowOldIsTheBook()} years old");
            Console.ReadKey();




        }
    }
}
