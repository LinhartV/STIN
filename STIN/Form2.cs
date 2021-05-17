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
        Graphics g;
        Bitmap bmp;
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            barGraph_chart();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            DrawSetup();
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
            
            DrawStateName("Anglie");

        }
        private void DrawSetup()
        {
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, bmp.Width, bmp.Height);
            pictureBox1.Image = bmp;
        }

        private void DrawStateName(string name)
        {
            g.DrawString(name, new Font("Arial", 16), new SolidBrush(Color.Black), 10, 10);
            pictureBox1.Image = bmp;
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
