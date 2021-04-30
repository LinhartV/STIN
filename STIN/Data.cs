using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STIN
{
    class Data
    {
        public List<int> totalCases = new List<int>();
        public bool isUpToDate;
        public string timeToUpdate = "";
        public string url;
        public int row;
        public int col;
        public string fileName;
        public DateTime lastRefresh;

        public Data(string url, string fileName, int col, int row)
        {
            this.url = url;
            this.row = row;
            this.col = col;
            this.fileName = fileName;
        }
    }
}
