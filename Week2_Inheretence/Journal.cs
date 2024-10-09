using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheretence
{

    //! Inheratance is denoted by :<base class>
    //! Base class is the class we are inherting it from
    //! When you inherit a class you are also inherting (making available) the public members & the protected members in that class)
    internal class Journal : Book
    {

      

        public int IssueNo { get; set; }

        public int Month { get; set; }

        public Journal() : base() //! we are making a call to the constroctor of the base class i.e. Book
        {
            //here within the hournal class i can acess the protected field called available 
            // unlike trying to acess it from an external non inherating class
           available = true;
        }

        public Journal(string isbn, int issueNo) : base(isbn) //! runs the constroctor declared inside the same class
        {
            IssueNo = issueNo;
        }
    }
}
