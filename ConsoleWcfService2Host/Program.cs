using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary2;

namespace ConsoleWcfService2Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(Service1))) 
            {
                host.AddServiceEndpoint(typeof(IService1),new BasicHttpsBinding(), "http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary2/Service1/basic");

                ServiceMetadataBehavior smb = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
                if (smb == null)
                {
                    smb = new ServiceMetadataBehavior();
                }
                smb.HttpGetEnabled = true;
                smb.HttpsGetEnabled = true;
                host.Description.Behaviors.Add(smb);

                host.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexHttpBinding(), "http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary2/Service1/mex");

                foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
                {
                    Console.WriteLine(@"Contract name:   {0}", endpoint.Contract.Name);
                    Console.WriteLine(@"Contract address:   {0}", endpoint.Address.Uri.AbsoluteUri);
                    foreach (AddressHeader header in endpoint.Address.Headers)
                    {
                        Console.WriteLine(@"Contract address name:   {0}", header.Name);
                        Console.WriteLine(@"Contract address namespace:   {0}", header.Namespace);
                    }
                }
                foreach (IServiceBehavior behavior in host.Description.Behaviors)
                {
                    Console.WriteLine(@"Behavior:   {0}", behavior.ToString());
                }

                Console.ReadLine();
            }
            
        }
    }
}
