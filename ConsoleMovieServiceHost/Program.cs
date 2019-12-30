using MovieServiceLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMovieServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MovieService)))
            {
                Console.WriteLine(host.Description.Name);
                foreach (var item in host.Description.Endpoints)
                {
                    Console.WriteLine(item.Address.Uri.AbsoluteUri);
                }
                Console.ReadLine();
            }
        }
    }
}
