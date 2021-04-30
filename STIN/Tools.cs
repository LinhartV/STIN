using FileHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace STIN
{
    static class Tools
    {
        public static void FormTransfer(Form thisForm, Form thatForm)
        {
            thatForm.Location = thisForm.Location;
            thatForm.Show();
            thisForm.Hide();
        }
        public static void StartApp()
        {
            //GlobalVars.form1.DateMzcr.Text = DateTime.Now.ToString().Substring(0,10);
            Repeat(() => Refresh(GlobalVars.who), 300000);
            Repeat(() => Refresh(GlobalVars.mzcr), 300000);
            Repeat(() => CheckNewDayAndTimeToRefresh(), 1000);
        }
        private static void ReadCSVFile(Data data)
        {
            //hello
            //download the file... pretty clear, ain't it
            using (var client = new WebClient())
            {
                client.DownloadFile(data.url, data.fileName);
            }
            //read one exact cell
            using (FileStream fs = new FileStream(data.fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string[] parts = sr.ReadToEnd().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    int value = Convert.ToInt32(parts[data.row].Split(',')[data.col]);
                    if (data.totalCases.Count == 0 || value != data.totalCases[data.totalCases.Count - 1])
                    {
                        data.isUpToDate = true;
                        if (data.totalCases.Count == 1)//get the 
                        {
                            data.timeToUpdate = DateTime.Now.ToString().Substring(11);
                        }
                        data.totalCases.Add(value);
                        data.lastRefresh = DateTime.Now;
                        VisualizeActualization(data);
                    }
                }
            }
        }


        private static async Task Repeat(Func<bool> action, int millisDelay) //takes in a method to repeat. If the method returns false, it will stop repeating
        {
            while (true)
            {
                if (action.Invoke() == false)
                    break;
                await Task.Delay(millisDelay);
            }
        }
        public static bool Refresh(Data data)
        {
            ReadCSVFile(data);
            if (data.lastRefresh.ToString().Substring(0, 10) != DateTime.Now.ToString().Substring(0, 10))
            {
                data.isUpToDate = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CheckNewDayAndTimeToRefresh()
        {
            if (DateTime.Now.ToString().Substring(11) == (GlobalVars.who.timeToUpdate))
            {
                Repeat(() => Refresh(GlobalVars.who), 300000);
            }
            if (DateTime.Now.ToString().Substring(11) == (GlobalVars.mzcr.timeToUpdate))
            {
                Repeat(() => Refresh(GlobalVars.mzcr), 300000);
            }
            if (DateTime.Now.ToString().EndsWith("00:00:00"))
            {
                GlobalVars.mzcr.isUpToDate = false;
                GlobalVars.who.isUpToDate = false;
                VisualizeActualization(GlobalVars.who);
                VisualizeActualization(GlobalVars.mzcr);
                if(GlobalVars.who.timeToUpdate == "")
                {
                    Repeat(() => Refresh(GlobalVars.who), 300000);
                }
                if (GlobalVars.mzcr.timeToUpdate == "")
                {
                    Repeat(() => Refresh(GlobalVars.mzcr), 300000);
                }
                //new day
            }
            return true;
        }

        private static void VisualizeActualization(Data data)
        {
            if (data == GlobalVars.mzcr)
            {
                GlobalVars.form1.TotalMzcr.Text = data.totalCases[data.totalCases.Count - 1].ToString();
                if (data.totalCases.Count > 1)
                    GlobalVars.form1.LastDayMzcr.Text = (data.totalCases[data.totalCases.Count - 1] - data.totalCases[data.totalCases.Count - 2]).ToString();
                GlobalVars.form1.DateMzcr.Text = data.lastRefresh.ToString().Substring(0, 10);
                if (data.isUpToDate)
                    GlobalVars.form1.label2.ForeColor = System.Drawing.Color.Green;
                else
                    GlobalVars.form1.label2.ForeColor = System.Drawing.Color.Red;
            }
            else if (data == GlobalVars.who)
            {
                GlobalVars.form1.TotalWho.Text = data.totalCases[data.totalCases.Count - 1].ToString();
                if (data.totalCases.Count > 1)
                    GlobalVars.form1.LastDayWho.Text = (data.totalCases[data.totalCases.Count - 1] - data.totalCases[data.totalCases.Count - 2]).ToString();
                GlobalVars.form1.DateWho.Text = data.lastRefresh.ToString().Substring(0,10);
                if (data.isUpToDate)
                    GlobalVars.form1.label1.ForeColor = System.Drawing.Color.Green;
                else
                    GlobalVars.form1.label1.ForeColor = System.Drawing.Color.Red;
            }
            if (GlobalVars.mzcr.isUpToDate && GlobalVars.who.isUpToDate)
            {
                GlobalVars.form1.TotalDifference.Text = (Math.Abs(GlobalVars.who.totalCases[GlobalVars.who.totalCases.Count - 1] - GlobalVars.mzcr.totalCases[GlobalVars.mzcr.totalCases.Count - 1])).ToString();
                if (data.totalCases.Count > 1)
                    GlobalVars.form1.LastDayDifference.Text = Math.Abs((GlobalVars.who.totalCases[GlobalVars.who.totalCases.Count - 1] - GlobalVars.who.totalCases[GlobalVars.who.totalCases.Count - 2]) - (GlobalVars.mzcr.totalCases[GlobalVars.mzcr.totalCases.Count - 1] - GlobalVars.mzcr.totalCases[GlobalVars.mzcr.totalCases.Count - 2])).ToString();
            }
            //up to you, Khai ;)
            //přes pictureBox to bude nejlepší, ty labels smaž, byly jen pro mě pro kontrolu
        }
    }
}
