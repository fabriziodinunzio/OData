using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary2
{
    public class Echo : IEcho
    {
        public string GetMessage(string message)
        {
            return message;
        }
    }
}
