using Log;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary2
{
    public class MyServiceBehavior : Attribute, IServiceBehavior
    {
        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
            MyLogger.Log("MyServiceBehaviorAttribute", "AddBindingParameters", serviceDescription.Name);
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            MyLogger.Log("MyServiceBehaviorAttribute", "ApplyDispatchBehavior", serviceDescription.Name);
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            MyLogger.Log("MyServiceBehaviorAttribute", "Validate", serviceDescription.Name);
        }
    }
}
