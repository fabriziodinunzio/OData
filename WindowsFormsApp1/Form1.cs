using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Person> dataSource = new List<Person>() { 
            new Person() { Id=1, CodiceFiscale="XXX", Nome="Franco", Cognome="Sensi"}
            ,
            new Person() { Id=1, CodiceFiscale="XXX", Nome="Franco", Cognome="Sensi"}
            ,
            new Person() { Id=1, CodiceFiscale="XXX", Nome="Franco", Cognome="Sensi"}
            ,
            new Person() { Id=2, CodiceFiscale="ZZZZZZZ", Nome="Anna", Cognome="Pavoletti"}
            ,
            new Person() { Id=3, CodiceFiscale="MMMMMMMM", Nome="Andrea", Cognome="Zirilli"}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = dataSource;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "FullName";

            comboBox2.DataSource = dataSource.Distinct(new PersonEqualityComparer()).ToList();
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "FullName";
        }
    }
}
