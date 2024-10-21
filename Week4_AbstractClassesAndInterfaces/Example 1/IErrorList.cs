using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces.Example_1
{

    //! Notes:

    //! 1. Abstract classes are created to be inherited
    //! 2. Interfaces cannot be instanstianted (you cannot create ibject of)
    //! 1. Unlike an abstract class ,in an interface you cannot have implemented methods 
    //! 4. you are forced to override  methods in oridary classes once inherited


    public interface IErrorList
    {
        List<Exception> Errors { get; set; }

        void LogErrors(Exception ex);

    }
}
