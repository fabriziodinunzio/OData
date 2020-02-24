using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.IO;

namespace XmlToExcel
{
    public class XmlLoader
    {
        public XmlLoader()
        {
            
        }

        protected List<DataSet> ReadData(TextReader[] xmlFilePathList, string[] nsArray)
        {
            List<DataSet> ret = new List<DataSet>();
            foreach (TextReader item in xmlFilePathList)
            {
                DataSet itemDataSet = new DataSet();
                itemDataSet.InferXmlSchema(item, nsArray);
                itemDataSet.ReadXml(item);
                ret.Add(itemDataSet);
            }
            return ret;
        }

        protected List<DataSet>ReadData(string[] xmlFilePathList, string[] nsArray)
        {
            List<DataSet> ret = new List<DataSet>();
            foreach (string item in xmlFilePathList)
            {
                DataSet itemDataSet = new DataSet();
                itemDataSet.InferXmlSchema(HttpContext.Current.Server.MapPath(item), nsArray);
                itemDataSet.ReadXml(HttpContext.Current.Server.MapPath(item));
                ret.Add(itemDataSet);
            }
            return ret;
        }

        private void RemoveFromColumns(DataTable dataTable, string columnToRemoveList)
        {
            if ((dataTable != null) && (dataTable.Columns.Count > 0) && !String.IsNullOrEmpty(columnToRemoveList))
            {
                string[] splitList = columnToRemoveList.Split('|');
                if (splitList != null && splitList.Count() > 0)
                {
                    foreach (string item in splitList)
                    {
                        if (dataTable.Columns.IndexOf(item) >= 0)
                        {
                            dataTable.Columns.Remove(item);
                        } 
                    }
                }
            }
        }

        public DataTable ReadDataTables(string xmlFilePathList, string tableName, string nsArray, string columnToRemoveList)
        {
            DataTable dtOut = new DataTable();
            
            //dtOut.Columns.Add("IdApplicazione", typeof(int));
            //dtOut.Columns.Add("DescApplicazione", typeof(string));
            List<DataRow> rows = null;
            List<DataTable> dataTableList = null;
            if (xmlFilePathList != String.Empty)
            {
                string[] xmlFilePathSplit = xmlFilePathList.Split('|');
                if (xmlFilePathSplit != null && xmlFilePathSplit.Count() > 0)
                {
                    string[] nsArraySplit = nsArray.Split('|');
                    dataTableList = ReadData(xmlFilePathSplit, nsArraySplit).Select(ds => ds.Tables[tableName]).ToList();
                }

                
                if (dataTableList != null && dataTableList.Count() > 0)
                {
                    rows = new List<DataRow>();
                    foreach (DataColumn item in dataTableList[0].Columns)
                    {
                        dtOut.Columns.Add(new DataColumn() { ColumnName = item.ColumnName, DataType = item.DataType });
                    }

                    RemoveFromColumns(dtOut, columnToRemoveList);
                    
                    foreach (DataTable tableItem in dataTableList)
                    {
                        foreach (DataRow rowItem in tableItem.Select())
                        {
                            DataRow newRow = dtOut.NewRow();
                            foreach (DataColumn columnItem in dtOut.Columns)
                            {
                                newRow[columnItem.ColumnName] = rowItem[columnItem.ColumnName];
                            }
                            dtOut.Rows.Add(newRow);
                        }
                    }

                    
                    
                }
            }
            //rows.Select(r => r.Field<string>("DescApplicazione")).ToList();
            return dtOut;
        }
    }
}
