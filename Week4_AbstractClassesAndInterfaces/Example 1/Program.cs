using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Log> myLogs  = new List<Log>();

            FileLog myLog = new FileLog();
            myLog.FilePath = "Log.txt";

            myLog.Id = 1;
            myLog.Timestamp = DateTime.Now;
            myLog.Description = "Testing Logs";
            myLog.Origin = "Program.cs";
            myLog.User = "Nathan";

            myLogs.Add(myLog);
            myLog.Save();


            System.Threading.Thread.Sleep(3000); //! make the application wait for 3 sec

            EmailLog myEmailLog = new EmailLog();

            myEmailLog.Id = 2;
            myEmailLog.Smpt = "smpt.gmail.com";
            myEmailLog.SmtID = "username";
            myEmailLog.SmtPassword = "password";
            myEmailLog.From = "nathanattard12345@gmail.com";
            myEmailLog.Recipitent = "nathanattard12345@gmail.com";

            myEmailLog.Timestamp = DateTime.Now;
            myEmailLog.Description = "Testing Logs";
            myEmailLog.Origin = "Program.cs";
            myEmailLog.User = "Nathan";
            myLogs.Add(myEmailLog);

            foreach (Log log in myLogs) 
            { 
                log.Save();
            }

        }
    }
}
