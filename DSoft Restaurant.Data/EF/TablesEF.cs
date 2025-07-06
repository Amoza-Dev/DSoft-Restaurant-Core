using DSoft_Restaurant.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class TablesEF : IDataHelper<TBTables>
    {
        private AppDBContext _context;
        private TBTables _tables;
        public TablesEF()
        {
            _context = new AppDBContext();
            _tables = new TBTables();   
        }

        public string Add(TBTables table)
        {
            try
            {
                _context.Tables.Add(table);
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
                _tables = Find(id);
                _context.Tables.Remove(_tables);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public TBTables Find(int id)
        {
            try
            {
                return _context.Tables.Find(id) ?? new TBTables();
            }
            catch (Exception)
            {
                return new TBTables();
            }
        }

        public List<TBTables> GetAll()
        {
            try
            {
                return _context.Tables.Include(x => x.TBZones).Where(x => !x.IsDelete).ToList();
            }
            catch (Exception)
            {
                return new List<TBTables>();
            }
        }

        public List<TBTables> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool IsCanConnect()
        {
            return _context.Database.CanConnect();
        }

        public List<TBTables> SearchAll(string search)
        {
            throw new NotImplementedException();
        }

        public List<TBTables> SearchAllByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }

        public string Update(TBTables table)
        {
            try
            {
                _context=new AppDBContext();    
                _context.Tables.Update(table);
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
