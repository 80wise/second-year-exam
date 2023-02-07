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
    public partial class DiagramForm : Form
    {
        public DiagramForm()
        {
            InitializeComponent();

            Collection<TransportMean> collection = Functions.FillCollection();
            var TM = (from trans in collection.list
                      group trans by trans.Type into gr
                      select new { type = gr.Key, count = gr.Count() }).ToList();
            foreach(var t in TM)
            {
                chart1.Series[0].Points.AddXY(t.type, t.count);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
