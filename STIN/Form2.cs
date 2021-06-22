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
using LiveCharts.Configurations;
using STIN.Properties;

namespace STIN
{
    public partial class Form2 : Form
    {
        public string[] cbox_states { get; set; }
        public string[] Labels { get; set; }
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            chart_1.AxisX.Add(new Axis
            {
                Labels = new[] { "Czechia",
                    Settings.Default["cbox_ld_2"].ToString(),
                    Settings.Default["cbox_ld_3"].ToString(),
                    Settings.Default["cbox_ld_4"].ToString(),
                    Settings.Default["cbox_ld_5"].ToString() },
                Separator = new Separator { Step = 1 }
            });
            chart_1.AxisY.Add(new Axis
            {
                Title = "Vaccinated people",
                LabelFormatter = value => value.ToString("N")
            });
            Form2 DataContext = this;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            load_list_combobox();
            cbox_state_2.Text = Settings.Default["cbox_ld_2"].ToString();
            cbox_state_3.Text = Settings.Default["cbox_ld_3"].ToString();
            cbox_state_4.Text = Settings.Default["cbox_ld_4"].ToString();
            cbox_state_5.Text = Settings.Default["cbox_ld_5"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tools.FormTransfer(this, GlobalVars.form1);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.form1.Close();
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            cbox_states = new[] { "Czechia",
                cbox_state_2.SelectedItem.ToString(),
                cbox_state_3.SelectedItem.ToString(),
                cbox_state_4.SelectedItem.ToString(),
                cbox_state_5.SelectedItem.ToString()
            };
            barGraph_chart(cbox_states);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Tools.DownloadWho("who" + DateTime.Now.ToString().Substring(0, 10) + ".csv");
        }

        public void barGraph_chart(string[] cbox_states)
        {
            try
            {
                List<List<double>> five_states = new List<List<double>>();
                for (int i = 0; i < 5; i++)
                    five_states.Add(Tools.ReadByState(cbox_states[i]));

                double[] latest_data = new double[5];
                double[] day_before = new double[5];
                for (int i = 0; i < 5; i++)
                {
                    latest_data[i] = five_states[i].Last();
                    day_before[i] = five_states[i][^2];
                    if (i != 0)
                        chart_1.AxisX[0].Labels[i] = cbox_states[i];
                }

                Settings.Default["cbox_ld_2"] = cbox_states[1];
                Settings.Default["cbox_ld_3"] = cbox_states[2];
                Settings.Default["cbox_ld_4"] = cbox_states[3];
                Settings.Default["cbox_ld_5"] = cbox_states[4];
                Settings.Default.Save();

                chart_1.Series = new LiveCharts.SeriesCollecion
            {

                new StackedColumnSeries()
                {
                    Title = "latest day",
                    Values = new ChartValues<double> { latest_data[0],
                        latest_data[1], latest_data[2],
                        latest_data[3], latest_data[3]
                    },
                    DataLabels = true
                },
                new StackedColumnSeries()
                {
                    Title = "previous day",
                    Values = new ChartValues<double> {
                        latest_data[0] - day_before[0],
                        latest_data[1] - day_before[1],
                        latest_data[2] - day_before[2],
                        latest_data[3] - day_before[3],
                        latest_data[4] - day_before[4]
                    },
                    StackMode = StackMode.Values,
                    DataLabels = true
                }
            };
            }
            catch (Exception e)
            {
                Tools.WriteErrorToLog(e);
            }
        }

        public void load_list_combobox()
        {
            List<String> arr_states = GlobalVars.states;
            arr_states.Sort();
            cbox_state_2.Items.Clear();
            cbox_state_3.Items.Clear();
            cbox_state_4.Items.Clear();
            cbox_state_5.Items.Clear();

            cbox_state_2.Items.AddRange(arr_states.ToArray());
            cbox_state_3.Items.AddRange(arr_states.ToArray());
            cbox_state_4.Items.AddRange(arr_states.ToArray());
            cbox_state_5.Items.AddRange(arr_states.ToArray());
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tools.EndAppAndSaveData();
        }
    }
}
