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
            Journal myJurnal = new Journal();

            Console.WriteLine($"Make for journal");
            myJurnal.Name = Console.ReadLine();

            myJurnal.IssueNo = 1;
            myJurnal.Month = 1;

            //! A typical TCA question would be like this

        }
    }
}
