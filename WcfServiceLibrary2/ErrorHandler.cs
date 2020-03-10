using Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary2
{
    public class ErrorHandler : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            MyLogger.Log("ErrorHandler", "HandleError", error.Message);
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            
        }
    }
}
