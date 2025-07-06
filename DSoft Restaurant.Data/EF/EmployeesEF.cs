using DSoft_Restaurant.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class EmployeesEF : IDataHelper<TBEmployees>
    {
        private AppDBContext _context;
        private TBEmployees _employees;
        public EmployeesEF()
        {
            _context = new AppDBContext();  
            _employees = new TBEmployees();
        }

        public string Add(TBEmployees table)
        {
            try
            {
                _context.Employees.Add(table);
                _context.SaveChanges();
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
                _employees = Find(id);
                _context.Employees.Remove(_employees);
                _context.SaveChanges(); 
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public TBEmployees Find(int id)
        {
            try
            {
                return _context.Employees.Find(id) ?? new TBEmployees();
            }
            catch (Exception)
            {
                return new TBEmployees();
            }
        }

        public List<TBEmployees> GetAll()
        {
            try
            {
                return _context.Employees.Include(x => x.TBEmployeeCategory).Where(x => !x.IsDelete).ToList();
            }
            catch (Exception)
            {
                return new List<TBEmployees>(); 
            }
        }

        public List<TBEmployees> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool IsCanConnect()
        {
            return _context.Database.CanConnect();
        }

        public List<TBEmployees> SearchAll(string search)
        {
            throw new NotImplementedException();
        }

        public List<TBEmployees> SearchAllByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }

        public string Update(TBEmployees table)
        {
            try
            {
                _context=new AppDBContext();
                _context.Employees.Update(table);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
