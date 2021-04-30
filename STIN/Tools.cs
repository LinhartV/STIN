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
        private static void ReadCSVFile(string url, string name, int column, int row, out int output)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(url, name);
            }
            using (FileStream fs = new FileStream(name, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string[] parts = sr.ReadToEnd().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    output = Convert.ToInt32(parts[row].Split(',')[column]);
                }
            }
        }
        
        public static void StartApp()
        {
            Repeat(Refresh, 50000);
            Repeat(()=>CheckNewDay(), 100);
        }
        
        private static async Task Repeat(Action action, int millisDelay)
        {
            while (true)
            {
                action.Invoke();
                await Task.Delay(millisDelay);
            }
        }
        public static void Refresh()
        {
            ReadCSVFile("https://covid19.who.int/WHO-COVID-19-global-table-data.csv", "who1.csv", 2, 20, out Data.whoTotalCases);
            ReadCSVFile("https://onemocneni-aktualne.mzcr.cz/api/v2/covid-19/zakladni-prehled.csv", "mzcr.csv", 1, 1, out Data.mzcrTotalCases);
        }
        private static void CheckNewDay()
        {
            if(DateTime.Now.ToString().EndsWith("00:00:00"))
            {
                //new day
            }
        }
    }
}
