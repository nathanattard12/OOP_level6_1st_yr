using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Intro
{
    //! Class is a blueprint/template which defines a "thing" from the real-world by grouping
    //! a set of related compoments/members
    internal class Person
    {
        //!properties 
        /// <summary>
            //like attributes which best describe the class is about
           //like containers for the data that will be assigned / accessed
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }

        public string FullName { get; set; }


        //methods
        //methods are behaviors which the class can have
        //e.g. a method to validate some property
        //e.g. a method regulates the data inside a particular property

        public string CapitlizeFullName()
        {
            return FullName.ToUpper();
        }
    }
}
