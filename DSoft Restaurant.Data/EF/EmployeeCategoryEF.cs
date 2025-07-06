using DSoft_Restaurant.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class EmployeeCategoryEF : IDataHelper<TBEmployeeCategory>
    {
        private AppDBContext _context;
        private TBEmployeeCategory _employeecategory;

        public EmployeeCategoryEF()
        {
            _context = new AppDBContext();
            _employeecategory = new TBEmployeeCategory();   
        }

        public string Add(TBEmployeeCategory table)
        {
            try
            {
                _context.EmployeeCategory.Add(table);
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
                _employeecategory=Find(id);
                _context.EmployeeCategory.Remove(_employeecategory);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public TBEmployeeCategory Find(int id)
        {
            try
            {
                return _context.EmployeeCategory.Find(id) ?? new TBEmployeeCategory();
            }
            catch (Exception)
            {
                return new TBEmployeeCategory();
            }
        }

        public List<TBEmployeeCategory> GetAll()
        {
            try
            {
                return _context.EmployeeCategory.Where(x => !x.IsDelete).ToList();
            }
            catch (Exception)
            {
                return new List<TBEmployeeCategory>();
            }
        }

        public List<TBEmployeeCategory> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool IsCanConnect()
        {
            return _context.Database.CanConnect();
        }

        public List<TBEmployeeCategory> SearchAll(string search)
        {
            throw new NotImplementedException();
        }

        public List<TBEmployeeCategory> SearchAllByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }

        public string Update(TBEmployeeCategory table)
        {
            try
            {
                _context = new AppDBContext();
                _context.EmployeeCategory.Update(table);
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
