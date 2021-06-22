using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STIN
{
    class Data
    {
        public Dictionary<int, int> totalCases = new Dictionary<int, int>();
        public bool isUpToDate = false;
        public string timeToUpdate = "";
        public string lastRefresh;
        public string url;
        public int row;
        public int col;
        public string fileName;

        public Data(string url, string fileName, int col, int row)
        {
            this.url = url;
            this.row = row;
            this.col = col;
            this.fileName = fileName;
        }
    }
}
