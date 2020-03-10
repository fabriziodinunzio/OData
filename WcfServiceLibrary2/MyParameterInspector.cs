using Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary2
{
    public class MyParameterInspector : IParameterInspector
    {
        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            MyLogger.Log("MyParameterInspector", "AfterCall", operationName);
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            MyLogger.Log("MyParameterInspector", "BeforeCall", operationName);
            return null;
        }
    }
}
