using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.IO;

namespace Vegan.Web.Models.PayPal
{
    public class PaypalLogger
    {
        public static string LogDirectoryPath = Environment.CurrentDirectory;
        public static void Log(String messages)
        {
            try
            {
                StreamWriter strw = new StreamWriter(LogDirectoryPath + "\\PaypalError.log", true);
                strw.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss" + "--->" + messages));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}