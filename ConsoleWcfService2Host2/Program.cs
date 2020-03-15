using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary2;

namespace ConsoleWcfService2Host2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
                {
                    Console.WriteLine(@"Contract name:   {0}", endpoint.Contract.Name);
                    Console.WriteLine(@"Contract address:   {0}", endpoint.Address.Uri.AbsoluteUri);
                    Console.WriteLine(@"ListenUri:   {0}", endpoint.ListenUri);
                    Console.WriteLine(@"ListenUriMode:   {0}", endpoint.ListenUriMode.ToString());
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
