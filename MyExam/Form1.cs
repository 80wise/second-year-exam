using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myTimer.Start();
           
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            Collection<TransportMean> collection = Functions.FillCollection();
            List<Person> people = new List<Person>();
            Person pers = new Person("dddd");


            TransportDGV.DataSource = collection.list;
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            Collection<TransportMean> collection = Functions.FillCollection();
            collection.list.Sort();
            TransportDGV.DataSource = collection.list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Collection<TransportMean> collection = Functions.FillCollection();

            XmlServices.WriteToXmlFile("tram.xml", collection.Find((TransportMean t) => t.Type == "tram"));
        }

        private void ShowNumberBtn_Click(object sender, EventArgs e)
        {
            Collection<TransportMean> collection = Functions.FillCollection();
            List<TransportMean> TM = collection.Find((TransportMean t) => t.Color == "red" && t.Price < 20000);
            textBox1.Text = TM.Count.ToString();
        }

        private void DiagramShow_Click(object sender, EventArgs e)
        {
            DiagramForm form = new DiagramForm();
            form.Show();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            TwoMiniteForm form = new TwoMiniteForm();
            form.Show();
        }
    }

    internal class ArrayList<T>
    {
    }
}
