using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace STIN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            barGraph_chart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tools.FormTransfer(this, GlobalVars.form1);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.form1.Close();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            testLabel.Text = Tools.ReadByState(GlobalVars.states[0])[0].ToString();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Tools.DownloadWho("who" + DateTime.Now.ToString().Substring(0, 10) + ".csv");
        }

        public void barGraph_chart()
        {
            chart_1.Series = new SeriesCollecion
            {
                new ColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                      new ObservableValue(4),
                      new ObservableValue(2)
                      // ...
                    }
                }
            };
        }
    }
}
