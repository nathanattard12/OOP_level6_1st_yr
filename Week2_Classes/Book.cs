using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Classes
{
    //! enums are predefined sets which you cannot dynamically modify
    public enum GenreType {Horror=1,Fiction=2,SciFi=3}

    //! a class is a representation of an entity , which is often referred to as a template 
    public class Book
    {
        //! Fields: the containers where data is actually stored
        private string name;
        private string auther;
        private bool available;


        //! the properties are the characteristics that make up the book
        //! through the properties we can GET or SET values
        //! preoprty is like the gateway to access the field via the GETTERS and SETTERS
        //! hence with properties i can controll the access/filter the data that goes into or out of the field 
        public string Name {  
            get
            {
                return name;
            }
            set
            {
                name = value.ToUpper();
            }
        }   
        public string Author { get; set; }
        public int Year { get; set; }
        public string Isbn { get; set; }
        public string Publisher { get; set; }

        public GenreType Genre { get; set;}

        public bool Available { 
            get 
            {
                return available;
            } 
        }
        public string Auther {
            get
            {
                string masked = "";
                for (int i = 0; i < auther.Length; i++)
                {
                    masked += "*";

                }
                return masked;
            } 
            set
            {
                auther = value;
            } 
        }


        //! Methods
        //! Are the behavior of a Book
        //! syntwax: <access> modifier><return type (if any)><Name><List of properties>

        public void Borrow(string isbn)
        {
            if(Available)
            {
                available = false;
            }
        }

        public int HowOldIsTheBook()
        {
            return DateTime.Now.Year - Year;
        }
    }

}
