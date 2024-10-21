using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces
{

    //! Noted:
    //! 1. Abstract classes are created to be inherited
    //! 2. Abstract classes cannot be instanstianted (you cannot create ibject of)
    //! 3. Abstract classes hold implemented and non-implemented numbers (properties + methods)
    //! 4. With Abstract Methods you are forced to override them unlike virtual methods in oridary classes


    //!Log is a record which goes in this registry which is timeline of events + descriptions
    public abstract class Log
    {

        public int Id {  get; set; }

        public string Description
        {
           get; set;
        }

        public DateTime Timestamp { get; set; }

        public string Origin { get; set; }

        public string User {  get; set; }




        //! When you don`t have enough details of what to implement in a particular behavior
        //! But at the same time some other behavior/memebrs are well-known
        //! its suitable to use Abstract Class`

        public abstract void Save();
        

        

        public override string ToString()
        {
            return $"Id: {Id}; Description: {Description}; " +
                $"Timestamp: {Timestamp.ToString("dd/MM/yyyy HH:mm:ss:f")}; Origin: {Origin}; User: {User}";
                    
        }
    }
}
