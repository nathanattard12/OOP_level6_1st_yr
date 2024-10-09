using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//! ====== Access Modifier ======

//!public - is the least restractive one. It makes the component accessible from everywhere
//!private - is the most restrictive one. it makes the component accissible only form the class where it is declared.
//!protected - it makes the component accessible from the class where it is declared and also from any inherited classes
//!internal - it makes the component accessible from inside the same library/project/namespace
namespace Week2_Inheretence
{
    //! enums are predefined sets which you cannot dynamically modify
    public enum GenreType { Horror = 1, Fiction = 2, SciFi = 3, None = 4 }

    //! a class is a representation of an entity , which is often referred to as a template 
    public class Book
    {

        //!1. A consturcter is there but hidden and you can declare it so as to unhide
        //!2. When you see a constructer without parameters, that is the default constructor
        //!3. A constructor is like a special method BUT without a return type
        //!4. A constructor bears the same name as the ClassG
        //!5. A secondary use to a constructor is to initialize varaible/fields/properties
        public Book()
        {
            available = true;
            HistoryOfIdsThatBorrowedTheBook = new List<string>(); //! the list can start adding data i.e. idcards numbers
            name = "";
            Genre = GenreType.None;

        }

        public Book(string isbn) : this() //! runs the constroctor declared inside the same class
        {

            Isbn = isbn;
        }


        //! Fields: the containers where data is actually stored
        private string name;
        private string auther;
        protected bool available;


        //! the properties are the characteristics that make up the book
        //! through the properties we can GET or SET values
        //! preoprty is like the gateway to access the field via the GETTERS and SETTERS
        //! hence with properties i can controll the access/filter the data that goes into or out of the field 
        public string Name
        {
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

        public GenreType Genre { get; set; }

        public List<string> HistoryOfIdsThatBorrowedTheBook { get; set; }

        public bool Available
        {
            get
            {
                return available;
            }
        }
        public string Auther
        {
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

        public void Borrow(string isbn, string idCardNo)
        {
            if (Available)
            {
                available = false;
                HistoryOfIdsThatBorrowedTheBook.Add(idCardNo);
            }
        }

        public int HowOldIsTheBook()
        {
            return DateTime.Now.Year - Year;
        }
    }

}
