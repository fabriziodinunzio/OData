using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using XmlToExcel;

namespace XmlToExcelWebClient
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MemoryStream> readerList = new List<MemoryStream>();
            try
            {
                foreach (string item  in new XmlDataList().Xml)
                {

                    MemoryStream reader = new MemoryStream(Encoding.UTF8.GetBytes(item));
                    readerList.Add(reader);
                }
                XmlLoader loader = new XmlLoader();
                DataTable dataTable = loader.ReadDataTables(readerList.ToArray(), "Applicazione", "http://www.w3.org/2001/XMLSchema-instance", "Id|Applicazione_Id|IsUsed");
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
                dataTable = loader.ReadDataTables(readerList.ToArray(), "Componente", "http://www.w3.org/2001/XMLSchema-instance", "Id|ListComponente_Id|Componente_Id|IsUsed");
                GridViewComponenti.DataSource = dataTable;
                GridViewComponenti.DataBind();
                dataTable = loader.ReadDataTables(readerList.ToArray(), "AaaComponente", "http://www.w3.org/2001/XMLSchema-instance", "Id|ListAaaComponente_Id|IsUsed");
                GridViewAaaComponenti.DataSource = dataTable;
                GridViewAaaComponenti.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                foreach (MemoryStream item in readerList)
                {
                    item.Dispose();
                }
                readerList = null;
            }

        }
    }
}