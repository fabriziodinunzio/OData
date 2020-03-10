using ConsoleService2WcfClient.ServiceLibrary2Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleService2WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Service1Client client = new Service1Client())
            {
                Console.WriteLine(client.GetData(23));
            }
            Console.ReadLine();
        }
    }
}
