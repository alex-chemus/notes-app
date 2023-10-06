using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Core
{
    internal enum Period
    {
        Day,
        Month,
        Quarter,
        Year
    }

    internal interface Income
    {
        int id { get; }
        string name { get; }
        int sum { get; }
        Period period { get; }
    }

    internal class IncomeImp : Income
    {
        public int id { get; }
        public string name { get; }
        public int sum { get; }
        public Period period { get; }

        public IncomeImp(int id, string name, int sum, Period period)
        {
            this.id = id;
            this.name = name;
            this.sum = sum;
            this.period = period;
        }
    }
}
