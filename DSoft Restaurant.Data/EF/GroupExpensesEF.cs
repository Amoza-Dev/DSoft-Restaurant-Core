using DSoft_Restaurant.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class GroupExpensesEF : IDataHelper<TBGroupExpenses>
    {
        private AppDBContext context;
        private TBGroupExpenses groupExpenses;
        public GroupExpensesEF()
        {
            context = new AppDBContext();
            groupExpenses = new TBGroupExpenses();
        }
        public string Add(TBGroupExpenses table)
        {
            try
            {
                context.GroupExpenses.Add(table);
                context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public string Delete(int id)
        {
            try
            {
                groupExpenses = Find(id);
                context.GroupExpenses.Remove(groupExpenses);
                context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public TBGroupExpenses Find(int id)
        {
            try
            {
                return context.GroupExpenses.Find(id) ?? new TBGroupExpenses();
            }
            catch (Exception)
            {
                return new TBGroupExpenses();
            }
        }

        public List<TBGroupExpenses> GetAll()
        {
            try
            {
                return context.GroupExpenses.Where(x => !x.IsDelete).ToList();
            }
            catch (Exception)
            {
                return new List<TBGroupExpenses>();
            }
        }

        public List<TBGroupExpenses> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool IsCanConnect()
        {
            return context.Database.CanConnect();
        }

        public List<TBGroupExpenses> SearchAll(string search)
        {
            throw new NotImplementedException();
        }

        public List<TBGroupExpenses> SearchAllByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }

        public string Update(TBGroupExpenses table)
        {
            try
            {
                context = new AppDBContext();
                context.GroupExpenses.Update(table);
                context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
