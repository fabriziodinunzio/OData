using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;

namespace XmlToExcel
{
    public class XmlLoader
    {
        public XmlLoader()
        {
            
        }

        protected DataSet ReadData(string xmlFilePath, string[] nsArray = null)
        {
            DataSet ret = new DataSet();
            ret.InferXmlSchema(HttpContext.Current.Server.MapPath(xmlFilePath), nsArray);
            return ret;
        }
    }

    public class TableLoader : XmlLoader
    {
        public TableLoader() : base()
        {

        }

        public DataTable ReadTable(string xmlFilePath,string tableName, string nsArrayList)
        {
            DataTable dataTable = base.ReadData(xmlFilePath, nsArrayList.Split('|')).Tables[tableName];
            return dataTable;
        }
    }
}
