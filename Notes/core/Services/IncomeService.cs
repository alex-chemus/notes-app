using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Core.Models;

namespace Notes.Core.Services
{
    internal class MonthIncomeDto
    {
        public int month { get; set; }
        public int sum { get; set; }
    }
}

namespace Notes.Core.Services
{
    internal class IncomeService
    {
        private IncomeRepository incomeRepository;

        public IncomeService(IncomeRepository incomeRepository)
        {
            this.incomeRepository = incomeRepository;
        }

        public void add(AddIncomeDto dto) => incomeRepository.Add(dto);

        private MonthIncomeDto getMonthIncome(int month)
        {
            int sum = 0;
            List<Income> incomes = incomeRepository.GetAll();

            foreach (var income in incomes)
            {
                switch (income.period)
                {
                    case Period.Month:
                        sum += income.sum;
                        break;

                    case Period.Day:
                        int days = DateTime.DaysInMonth(DateTime.Now.Year, month);
                        sum += income.sum * days;
                        break;

                    case Period.Quarter:
                        if (month == 3 || month == 6 || month == 9 || month == 12) sum += income.sum;
                        break;

                    case Period.Year:
                        if (month == 12) sum += income.sum;
                        break;
                }
            }

            return new MonthIncomeDto { month = month, sum = sum };
        }

        public List<MonthIncomeDto> getYearIncome()
        {
            var yearIncome = new List<MonthIncomeDto>();
            for (int i=1; i<=12; i++)
                yearIncome.Add(getMonthIncome(i));
            return yearIncome;
        }
    }
}
