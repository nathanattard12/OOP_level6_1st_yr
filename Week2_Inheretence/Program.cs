using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheretence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {

                Console.WriteLine("Choose between ");
                Console.WriteLine("1. Book");
                Console.WriteLine("2. Journal");
                Console.WriteLine("3. Scientific Journal");
                choice = Convert.ToInt32(Console.ReadLine());

            } while (choice <1 || choice >3);

            Book b = null;
            switch (choice)
            {
                case 1:
                    b = new Book();
                    break;

                case 2:
                    Console.WriteLine("Input issue Number");
                    int issueNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input Month");
                    int month = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input ISBN");
                    string isbn = Console.ReadLine();

                    b = new Journal(isbn,issueNo,month); //! this is allowed because Journal is a Book
                    break;

                case 3:
                    Console.WriteLine("Input issue Number");
                    int issueNo2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input Month");
                    int month2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input ISBN");
                    string isbn2 = Console.ReadLine();

                    Console.WriteLine("Input field of Study");
                    string field = Console.ReadLine();

                    b = new ScientificJournal(field,issueNo2,isbn2,month2);
                    break;

                default:
                    b = new Book(); //The code will resort to this in case the choices are is not 1 and 3
                    break;
            }

            Console.WriteLine("Input Name");
            b.Name = Console.ReadLine();

            Console.WriteLine("Input Author");
            b.Author = Console.ReadLine();

            Console.WriteLine("Input Year");
            b.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------------\n");
            b.Print(); // Since Journal/Scientifc Jorunal both inherit from the book, they get to inherit PRINT()
            Console.WriteLine("Hit a key to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
