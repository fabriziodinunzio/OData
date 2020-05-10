using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentNullFault))]
        string GetMessage(string message);
    }
}
