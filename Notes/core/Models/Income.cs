using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Core.Models
{
    internal enum Period
    {
        Day,
        Month,
        Quarter,
        Year
    }
}

namespace Notes.Core.Models
{
    internal interface Income
    {
        int id { get; set; }
        string name { get; set; }
        int sum { get; set; }
        Period period { get; set; }
    }
}

namespace Notes.Core.Models
{
    internal class IncomeDto: Income
    {
        public int id { get; set; }
        public string name { get; set; }
        public int sum { get; set; }
        public Period period { get; set; }
    }
}

namespace Notes.Core.Models
{
    internal class AddIncomeDto
    {
        public string name { get; set; }
        public int sum { get; set; }
        public Period period { get; set; }
    }
}

namespace Notes.Core.Models
{
    internal interface IncomeRepository
    {
        public List<Income> GetAll();
        public void Add(AddIncomeDto dto);
    }
}