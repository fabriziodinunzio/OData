using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public static class MyLogger
    {
        private static void Log(string message)
        {
            try
            {
                using (StreamWriter stream = new StreamWriter(String.Format(@"E:\log_{0}.log", DateTime.Now.ToString("dd-MM-yyyy")+ "." + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString()), true))
                {
                    stream.WriteLine(message);

                    stream.Flush();
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Log(string className, string methodName, string parameter)
        {
            Log(string.Format("Class {0} called method {1} with parameter {2} @ {3}",
                   className, methodName, parameter, DateTime.Now));
        }

    }
}
