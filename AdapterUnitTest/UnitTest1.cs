using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using AdapterDemo;
using AdapterDemo.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterUnitTest
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDbDataAdapter adapter = new StubDbAdapter();
            DataRenderer renderer = new DataRenderer(adapter);
            StringWriter writer = new StringWriter();
            renderer.Render(writer);
            string result = writer.ToString();
            Console.WriteLine(result);
            Assert.AreEqual(5, result.Count(c => c == '\n'));
        }

        [TestMethod]
        public void TestMethod2()
        {
            IDbDataAdapter oleDbAdapter = new SqlDataAdapter(@"SELECT Id, Nome, Descrizione FROM TestTable", new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FabrizioDiNunzio\source\repos\OData\AdapterDemo\TestDatabase.mdf;Integrated Security=True"));
            DataRenderer renderer = new DataRenderer(oleDbAdapter);
            StringWriter writer = new StringWriter();
            renderer.Render(writer);
            string result = writer.ToString();
            Console.WriteLine(result);
            Assert.AreEqual(6, result.Count(c => c == '\n'));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Pattern[] patterns = { 
                new Pattern() { Id = 1, Name = "Adapter", Description = "Adattatore" }
                ,
                new Pattern() { Id = 2, Name = "Composite", Description = "Composto liste" }
                ,
                new Pattern() { Id = 3, Name = "Singleton", Description = "Solo soletto" }
            };
            IRenderAdapter adapter = new RenderAdapter();
            PatternRenderer renderer = new PatternRenderer(adapter);
            string result = renderer.ListPatterns(patterns);
            Console.WriteLine(result);
            Assert.AreEqual(5, result.Count(c => c == '\n'));
        }
    }
}
