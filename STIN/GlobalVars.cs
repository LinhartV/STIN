using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STIN
{
    static class GlobalVars
    {
        public static Form1 form1;
        public static Form2 form2;
        public static Data who = new Data("https://covid19.who.int/WHO-COVID-19-global-table-data.csv", "who1.csv", 2, 20);
        public static Data mzcr = new Data("https://onemocneni-aktualne.mzcr.cz/api/v2/covid-19/zakladni-prehled.csv", "mzcr.csv", 1, 1);
        public static List<string> states = new List<string>();
        public static List<string> whoFileNames = new List<string>();
        public static Dictionary<string, int> dates = new Dictionary<string, int>();
    }
}
