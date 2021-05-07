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

                MessageBox.Show("Downloaded");
            }
            catch(WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void set_upToDate_label()
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
    }
}
