﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STIN
{
    public class MyWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            HttpWebRequest request = base.GetWebRequest(address) as HttpWebRequest;
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            return request;
        }
    }
    static class Tools
    {
        public static void WriteErrorToLog(Exception e)
        {
            File.AppendAllText("Log.txt", DateTime.Now.ToString() + "\n" + e.Message + "\n\n");
            MessageBox.Show("Something went wrong, see log for more information", "Are you kidding me?");
        }
        public static void FormTransfer(Form thisForm, Form thatForm)
        {
            thatForm.Location = thisForm.Location;
            thatForm.Show();
            thisForm.Hide();
        }
        public static void StartApp()
        {
            GetStateNames();
            GlobalVars.form2.load_list_combobox();
            Repeat(() => Refresh(GlobalVars.who), 300000);
            Repeat(() => Refresh(GlobalVars.mzcr), 300000);
            Repeat(() => DownloadWho(("who" + DateTime.Now.ToString().Substring(0, 10)) + ".csv"), 600000);
            Repeat(() => CheckNewDayAndTimeToRefresh(), 1000);
        }
        private static void GetStateNames()
        {
            try
            {

                //download the file for the first time
                string fileName = "who" + DateTime.Now.ToString().Substring(0, 10) + ".csv";
                //Khai - existing directory
                string new_dir = Directory.GetCurrentDirectory() + "\\who" + DateTime.Now.ToString().Substring(0, 10);
                bool dir_exists = System.IO.Directory.Exists(new_dir);
                if (!dir_exists)
                    System.IO.Directory.CreateDirectory(new_dir);
                DownloadWho(fileName);
                //get names
                string just = File.ReadAllText(fileName);
                string[] parts = File.ReadAllText(fileName).Replace(',', '|').Replace("Bonaire| Sint Eustatius and Saba", "Bonaire, Sint Eustatius and Saba").Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                for (int i = 1; i < parts.Length; i++)
                {
                    GlobalVars.states.Add(parts[i].Split('|')[0]);
                }
            }
            catch (Exception e)
            {
                WriteErrorToLog(e);
            }
        }
        public static bool DownloadWho(string fileName)
        {
            try
            {
                if (GlobalVars.whoFileNames.Count > 0 && fileName != GlobalVars.whoFileNames[GlobalVars.whoFileNames.Count - 1])
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://covid19.who.int/who-data/vaccination-data.csv", "test" + fileName);
                    }
                    if (File.ReadAllText(GlobalVars.whoFileNames[GlobalVars.whoFileNames.Count - 1]) != File.ReadAllText("test" + fileName))
                    {
                        File.Delete(GlobalVars.whoFileNames[GlobalVars.whoFileNames.Count - 1]);
                        File.Move("test" + fileName, fileName);
                        GlobalVars.whoFileNames[GlobalVars.whoFileNames.Count - 1] = fileName;
                    }
                }
                else
                {
                    using (var client = new MyWebClient())
                    {
                        client.DownloadFile("https://covid19.who.int/who-data/vaccination-data.csv", fileName);
                        GlobalVars.whoFileNames.Add(fileName);
                    }
                }
            }
            catch (WebException e)
            {
                WriteErrorToLog(e);
            }
            return true;
        }

        private static void ReadCSVFileByCell(Data data)
        {
            try
            {

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
                        if (data.totalCases.Count == 0 || value != data.totalCases[data.totalCases.Count-1])
                        {
                            data.isUpToDate = true;
                            if (data.totalCases.Count == 1)//get the time to refresh
                            {
                                data.timeToUpdate = DateTime.Now.ToString().Substring(11);
                            }
                            data.totalCases.Add(data.totalCases.Count, value);
                            if(!GlobalVars.dates.ContainsKey(DateTime.Now.ToString().Substring(0, 10)))
                                GlobalVars.dates.Add(DateTime.Now.ToString().Substring(0, 10), GlobalVars.dates.Count);
                            data.lastRefresh = DateTime.Now;
                            VisualizeActualization(data, data.totalCases.Count-1);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                WriteErrorToLog(e);
            }
        }


        private static async Task Repeat(Func<bool> action, int millisDelay) //takes in a method to repeat. If the method returns false, repeating will cease
        {
            while (true)
            {
                if (action.Invoke() == false)
                    break;
                await Task.Delay(millisDelay);
            }
        }
        public static List<double> ReadByState(string state)
        {
            try
            {
                string[] states;
                string[] stateInfo;
                List<double> output = new List<double>();
                for (int i = 0; i < GlobalVars.whoFileNames.Count; i++)
                {
                    states = File.ReadAllText(GlobalVars.whoFileNames[i]).Replace(',', '|').Replace("Bonaire| Sint Eustatius and Saba", "Bonaire, Sint Eustatius and Saba").Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    for (int j = 0; j < states.Length; j++)
                    {
                        stateInfo = states[j].Split('|');
                        if (state == stateInfo[0])
                        {
                            output.Add(Convert.ToDouble(stateInfo[7].Replace('.', ',')));
                            break;
                        }
                    }
                }
                return output;
            }
            catch (Exception e)
            {
                WriteErrorToLog(e);
                return new List<double>();
            }
        }
        public static bool Refresh(Data data)
        {
            ReadCSVFileByCell(data);
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
            try
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
                    VisualizeActualization(GlobalVars.who, GlobalVars.who.totalCases.Count);
                    VisualizeActualization(GlobalVars.mzcr, GlobalVars.mzcr.totalCases.Count);
                    if (GlobalVars.who.timeToUpdate == "")
                    {
                        Repeat(() => Refresh(GlobalVars.who), 300000);
                    }
                    if (GlobalVars.mzcr.timeToUpdate == "")
                    {
                        Repeat(() => Refresh(GlobalVars.mzcr), 300000);
                    }
                    //new day
                }
            }
            catch (Exception e)
            {
                WriteErrorToLog(e);
            }
            return true;
        }

        private static void VisualizeActualization(Data data, int dayNum)
        {
            if (data == GlobalVars.mzcr)
            {
                GlobalVars.form1.TotalMzcr.Text = data.totalCases[dayNum].ToString();
                if (data.totalCases.Count > 1)
                    GlobalVars.form1.LastDayMzcr.Text = (data.totalCases[dayNum] - data.totalCases[dayNum]).ToString();
                GlobalVars.form1.DateMzcr.Text = data.lastRefresh.ToString().Substring(0, 10);
                if (data.isUpToDate)
                    GlobalVars.form1.label2.ForeColor = System.Drawing.Color.Green;
                else
                    GlobalVars.form1.label2.ForeColor = System.Drawing.Color.Red;
            }
            else if (data == GlobalVars.who)
            {
                GlobalVars.form1.TotalWho.Text = data.totalCases[dayNum].ToString();
                if (data.totalCases.Count > 1)
                    GlobalVars.form1.LastDayWho.Text = (data.totalCases[dayNum] - data.totalCases[data.totalCases.Count - 2]).ToString();
                GlobalVars.form1.DateWho.Text = data.lastRefresh.ToString().Substring(0, 10);
                if (data.isUpToDate)
                    GlobalVars.form1.label1.ForeColor = System.Drawing.Color.Green;
                else
                    GlobalVars.form1.label1.ForeColor = System.Drawing.Color.Red;
            }
            if (GlobalVars.mzcr.isUpToDate && GlobalVars.who.isUpToDate)
            {
                GlobalVars.form1.TotalDifference.Text = (Math.Abs(GlobalVars.who.totalCases[dayNum] - GlobalVars.mzcr.totalCases[dayNum])).ToString();
                if (data.totalCases.Count > 1)
                    GlobalVars.form1.LastDayDifference.Text = Math.Abs((GlobalVars.who.totalCases[dayNum] - GlobalVars.who.totalCases[dayNum - 1]) - (GlobalVars.mzcr.totalCases[dayNum] - GlobalVars.mzcr.totalCases[dayNum - 1])).ToString();
            }
        }
    }
}
