using DSoft_Restaurant.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class ExpensesEF : IDataHelper<TBExpenses>
    {
        public ExpensesEF()
        {
        }

        public string Add(TBExpenses table)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TBExpenses Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBExpenses> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TBExpenses> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool IsCanConnect()
        {
            throw new NotImplementedException();
        }

        public List<TBExpenses> SearchAll(string search)
        {
            throw new NotImplementedException();
        }

        public List<TBExpenses> SearchAllByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }

        public string Update(TBExpenses table)
        {
            throw new NotImplementedException();
        }
    }
}
