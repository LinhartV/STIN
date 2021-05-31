using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            GlobalVars.form1 = this;
            if (GlobalVars.form2 == null)
                GlobalVars.form2 = new Form2();
            Tools.StartApp();
            GlobalVars.form1.set_upToDate_label();
            Tools.VisualizeActualization(0);
            set_upToDate_label();
            set_cbox_select_day();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tools.FormTransfer(this, GlobalVars.form2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.Refresh(GlobalVars.who);
                Tools.Refresh(GlobalVars.mzcr);
            }
            catch (WebException ex)
            {
                Tools.WriteErrorToLog(ex);
            }
            catch (Exception ex)
            {
                Tools.WriteErrorToLog(ex);
            }
        }

        public void set_upToDate_label()
        {
            if (GlobalVars.who.isUpToDate && GlobalVars.mzcr.isUpToDate)
            {
                GlobalVars.form1.info_label.BackColor = Color.MediumSpringGreen;
                GlobalVars.form1.info_label.Text = "WHO data are UpToDate\nMZCR data are UpToDate";
            }
            else
            {
                GlobalVars.form1.info_label.BackColor = Color.Crimson;
                if (!GlobalVars.who.isUpToDate && GlobalVars.mzcr.isUpToDate)
                    GlobalVars.form1.info_label.Text = "WHO data are NOT UpToDate\nMZCR data are UpToDate";
                else if (!GlobalVars.mzcr.isUpToDate && GlobalVars.who.isUpToDate)
                    GlobalVars.form1.info_label.Text = "WHO data are UpToDate\nMZCR data are NOT UpToDate";
                else
                    GlobalVars.form1.info_label.Text = "WHO data are NOT UpToDate\nMZCR data are NOT UpToDate";
            }
        }

        public void set_cbox_select_day()
        {
            foreach (string day in GlobalVars.dates.Keys)
            {
                if (!cbox_select_day.Items.Contains(day))
                    cbox_select_day.Items.Add(day);
            }
            //GlobalVars.form1.cbox_select_day.Items.Add();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_day = cbox_select_day.SelectedItem.ToString();
            Tools.VisualizeActualization(GlobalVars.dates[selected_day]);

        }
    }
}
