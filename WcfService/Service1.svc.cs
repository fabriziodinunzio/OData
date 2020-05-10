using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice, nel file svc e nel file di configurazione contemporaneamente.
    // NOTA: per avviare il client di prova WCF per testare il servizio, selezionare Service1.svc o Service1.svc.cs in Esplora soluzioni e avviare il debug.
    public class Service1 : IService1, IEchoService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            try
            {
                if (composite == null)
                {
                    throw new ArgumentNullException("composite");
                }
                if (composite.BoolValue)
                {
                    composite.StringValue += "Suffix";
                }
                return composite;
            }
            catch (ArgumentNullException ex)
            {
                CompositeTypeFault flt = new CompositeTypeFault();
                flt.Message = ex.Message;
                flt.Description = "Eccezione per IService.GetDataUsingDataContract";
                throw new FaultException<CompositeTypeFault>(flt, new FaultReason(flt.Description));
            }
        }

        public string GetMessage(string message)
        {
            try
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new ArgumentNullException("message");
                }
                return message;
            }
            catch (Exception ex)
            {
                ArgumentNullFault flt = new ArgumentNullFault();
                flt.Message = ex.Message;
                flt.Description = "Eccezione per IEchoService.GetMessage";
                throw new FaultException<ArgumentNullFault>(flt, new FaultReason(flt.Description));
            }
        }
    }
}
