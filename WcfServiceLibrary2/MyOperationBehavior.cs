using Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary2
{
    public class MyOperationBehavior : Attribute,  IOperationBehavior
    {
        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
        {
            MyLogger.Log("MyOperationBehavior", "AddBindingParameters", operationDescription.Name);
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
            clientOperation.ClientParameterInspectors.Add(new MyParameterInspector());
            MyLogger.Log("MyOperationBehavior", "ApplyClientBehavior", operationDescription.Name);
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            dispatchOperation.ParameterInspectors.Add(new MyParameterInspector());
            MyLogger.Log("MyOperationBehavior", "ApplyDispatchBehavior", operationDescription.Name);
        }

        public void Validate(OperationDescription operationDescription)
        {
            MyLogger.Log("MyOperationBehavior", "Validate", operationDescription.Name);
        }
    }
}
