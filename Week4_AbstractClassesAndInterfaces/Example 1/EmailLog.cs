using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces
{
    internal class EmailLog : Log
    {
         public string Recipitent {  get; set; }

         public string From {  get; set; }

         public string SmtID { get; set; }

         public string SmtPassword {  get; set; }

         public string Smpt { get; set; }

        public override void Save() //! this is never going to wrok unless you provide actual details and with google it reqquries more permission
        {
            MailMessage mm = new MailMessage(From,Recipitent);
            SmtpClient smpt = new SmtpClient(Smpt);
            smpt.Credentials = new NetworkCredential(SmtID, SmtPassword);

            mm.Subject = "Log #Id" + Id;
            mm.Body = this.ToString();

            smpt.Send(mm);
        }
    }
}
