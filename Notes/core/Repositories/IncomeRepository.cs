using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Core;

namespace Notes.Core.Repositories
{
    internal class AddIncomeDto
    {
        public string name;
        public int sum;
        public Period period;

        public AddIncomeDto(string name, int sum, Period period) 
        {
            this.name = name;
            this.sum = sum;
            this.period = period;
        }
    }

    internal interface IncomeRepository
    {
        public List<Income> GetAll();
        public void Add(AddIncomeDto dto);
    }
}
