using ConsoleWcfService1Client1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWcfService1Client1
{
    class Program
    {
        static void Main(string[] args)
        {
			ChannelFactory<IEchoServiceChannel> channelEchoFactory = new ChannelFactory<IEchoServiceChannel>("BasicHttpBinding_IEchoService");
			IEchoServiceChannel channelEcho = channelEchoFactory.CreateChannel();
			try
			{
				Console.WriteLine("Message	{0}", channelEcho.GetMessage("Ciao sono io"));
				Console.WriteLine("Message	{0}", channelEcho.GetMessage(null));
				channelEcho.Close();
			}
			catch (FaultException<ArgumentNullFault> fe1)
			{
				Console.WriteLine("ECCEZIONE {0} {1}", fe1.Detail.Message, fe1.Message);
				channelEcho.Abort();
			}
			Console.ReadLine();
		}
    }
}
