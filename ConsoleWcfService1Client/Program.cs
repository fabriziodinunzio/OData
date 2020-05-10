using ConsoleWcfService1Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWcfService1Client
{
    class Program
    {
        static void Main(string[] args)
        {

			ChannelFactory<IService1Channel> channelFactory = new ChannelFactory<IService1Channel>("BasicHttpBinding_IService1");
			IService1Channel channel = channelFactory.CreateChannel();
			try
			{
				
				Console.WriteLine("VALUE	{0}", channel.GetData(45));
				CompositeType data = channel.GetDataUsingDataContract(new CompositeType() { BoolValue = true, StringValue = "ECCOMI" });
				Console.WriteLine("BOOLVALUE	{0}	STRINGVALUE		{1}", data.BoolValue, data.StringValue);
				data = channel.GetDataUsingDataContract(null);
				Console.WriteLine("BOOLVALUE	{0}	STRINGVALUE		{1}", data.BoolValue, data.StringValue);
				channel.Close();
			}
			catch (FaultException<CompositeTypeFault> fe)
			{
				Console.WriteLine("ECCEZIONE {0} {1}", fe.Detail.Message, fe.Reason);
				channel.Abort(); 
			}
			//ChannelFactory<IEchoServiceChannel> channelEchoFactory = new ChannelFactory<IEchoServiceChannel>("BasicHttpBinding_IEchoService");
			//IEchoServiceChannel channelEcho = channelEchoFactory.CreateChannel();
			//try
			//{
			//	Console.WriteLine("Message	{0}", channelEcho.GetMessage("Ciao sono io"));
			//	channelEcho.Close();
			//}
			//catch (FaultException fe1)
			//{
			//	Console.WriteLine("ECCEZIONE {0}", fe1.Message);
			//	channelEcho.Abort();
			//}
			Console.ReadLine();
			
        }
    }
}
