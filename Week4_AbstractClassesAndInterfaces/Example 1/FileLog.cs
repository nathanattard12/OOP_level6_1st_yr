using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_AbstractClassesAndInterfaces.Example_1;

namespace Week4_AbstractClassesAndInterfaces
{
    internal class FileLog : Log, IErrorList, ISort
    {
        //! Unlike Abstract classes, I can inherit from as many interfaces i need
        //! With Abstract class i can only inherit ONE
        public string FilePath { get; set; }

        //! Memebrs inheriting from IErrorList
       public List<Exception> Errors { get; set; }

        public void LogErrors(Exception ex)
        {
            if (Errors == null)
            {
                Errors = new List<Exception>();
            }

            Exception innerException = ex.InnerException;
            while (innerException != null)
            {
                Errors.Add(innerException);
                innerException = innerException.InnerException; //if this will be null it wont go into the loop agan

                Description += innerException.Message + "\n";
            }

            Errors.Add(ex);
            Description += ex.Message + "\n";
        }

        //! ---------------------------------------------

        public override void Save()
        {

            System.IO.File.AppendAllText(FilePath,this.ToString());
        
        }
        //! Memebrs inehriting from ISort

        public void Sort(List<Log> logs)
        {
            logs.Sort((log1, log2) => log1.Timestamp.CompareTo(log2.Timestamp);
        }
    }
}
