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
    }
}
