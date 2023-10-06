using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Core;
using Notes.Core.Models;

namespace Notes.Db.Repositories
{
    internal class IncomeRepositoryImp : IncomeRepository
    {
        private DbHelper db;

        public IncomeRepositoryImp()
        {
            db = new DbHelper();
        }

        private Period mapPeriodToEnum(string period)
        {
            switch (period)
            {
                case "день": return Period.Day;
                case "месяц": return Period.Month;
                case "квартал": return Period.Quarter;
                default: return Period.Year;
            }
        }

        private List<Income> mapTableRecord(DataTable records)
        {
            var list = new List<Income>();
            foreach (DataRow row in records.Rows)
            {
                list.Add(new IncomeDto
                {
                    id = (int)row["id"],
                    name = (string)row["name"],
                    sum = (int)row["amount"],
                    period = mapPeriodToEnum((string)row["period"])
                });
            }
            return list;
        }

        public List<Income> GetAll()
        {
            string query = $"select * from incomes";
            DataTable records = db.getRecords(query);
            return mapTableRecord(records);
        }

        public void Add(AddIncomeDto dto)
        {
            string query = $"insert into incomes (" +
                $"`name`, `amount`, `period`" +
                $") values (" +
                $"'{dto.name}', '{dto.sum}', {dto.period})";
            db.InsertRecord(query);
        }
    }
}
