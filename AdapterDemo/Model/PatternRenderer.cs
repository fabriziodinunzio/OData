using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo.Model
{
    public class PatternRenderer
    {
        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return patterns.ToString();
        }
    }

    public class PatternDbDataAdapter : IDbDataAdapter
    {
        private IEnumerable<Pattern> _patterns;

        public PatternDbDataAdapter(IEnumerable<Pattern> patterns)
        {
            _patterns = patterns;
        }
        public int Fill(DataSet dataSet)
        {
            DataTable table1 = new DataTable("Pattern");
            table1.Columns.Add("Id", typeof(UInt32));
            table1.Columns.Add("Name", typeof(string));
            table1.Columns.Add("Description", typeof(string));
            foreach (Pattern item in _patterns)
            {
                DataRow newRow = table1.NewRow();
                newRow["Id"] = item.Id;
                newRow["Name"] = item.Name;
                newRow["Description"] = item.Description;
                table1.Rows.Add(newRow);
            }
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

    public interface IRendereAdapter
    {
        void Render(TextWriter writer);
    }

    public class RenderAdapter : IRendereAdapter
    {
        IDbDataAdapter _patternDbDataAdapter;
        public RenderAdapter(IDbDataAdapter patternDbDataAdapter)
        {
            _patternDbDataAdapter = patternDbDataAdapter;
        }
        public void Render(TextWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
