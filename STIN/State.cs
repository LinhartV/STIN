using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STIN
{
    class State
    {
        public string name;
        public string lastUpdated;
        public double vacctination;

        public State(string name, string lastUpdated, double vacctination)
        {
            this.name = name;
            this.lastUpdated = lastUpdated;
            this.vacctination = vacctination;
        }
    }
}
