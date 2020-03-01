using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class StubDbAdapter : IDbDataAdapter
    {
        public int Fill(DataSet dataSet)
        {
            DataTable table1 = new DataTable("Pattern");
            table1.Columns.Add("Id", typeof(UInt32));
            table1.Columns.Add("Name", typeof(string));
            table1.Columns.Add("Description", typeof(string));

            DataRow newRow = table1.NewRow();
            newRow["Id"] = 1;
            newRow["Name"] = "Adapter";
            newRow["Description"] = "Questo pattern adatta le interfacce incompatibili";
            table1.Rows.Add(newRow);

            newRow = table1.NewRow();
            newRow["Id"] = 2;
            newRow["Name"] = "Singleton";
            newRow["Description"] = "Questo pattern crea una sola istanza";
            table1.Rows.Add(newRow);

            newRow = table1.NewRow();
            newRow["Id"] = 3;
            newRow["Name"] = "Composite";
            newRow["Description"] = "Questo pattern serve per le liste";
            table1.Rows.Add(newRow);

            dataSet.Tables.Add(table1);
            dataSet.AcceptChanges();

            return table1.Rows.Count;
        }

        #region NOT IMPLEMENTED
        public IDbCommand SelectCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand InsertCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand UpdateCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ITableMappingCollection TableMappings => throw new NotImplementedException();

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
