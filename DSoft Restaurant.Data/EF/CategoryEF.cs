using DSoft_Restaurant.Core.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class CategoryEF : IDataHelper<TBCategory>
    {
        private AppDBContext _context;
        private TBCategory _category;

        public CategoryEF()
        {
            _context = new AppDBContext();
            _category = new TBCategory();
        }
        public string Add(TBCategory table)
        {
            try
            {
                _context.Categoroy.Add(table);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return $"Error: {ex.Message}";
            }
        }

        public string Delete(int id)
        {
            try
            {
                _category = Find(id);
                _context.Categoroy.Remove(_category);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return $"Error: {ex.Message}";
            }
        }

        public TBCategory Find(int id)
        {
            try
            {
                return _context.Categoroy.Find(id) ?? new TBCategory();
            }
            catch (Exception)
            {

                return new TBCategory();
            }

        }

        public List<TBCategory> GetAll()
        {
            try
            {
                return _context.Categoroy.Where(x => x.IsDelete == false).ToList();
            }
            catch (Exception)
            {
                return new List<TBCategory>();
            }

        }

        public List<TBCategory> GetAllByUserId(int userId)
        {
            try
            {
                return _context.Categoroy.Where(x => x.ID == userId).ToList();
            }
            catch (Exception)
            {
                return new List<TBCategory>();
            }
        }

        public bool IsCanConnect()
        {
            return _context.Database.CanConnect();
        }

        public List<TBCategory> SearchAll(string search)
        {
            try
            {
                return _context.Categoroy.Where(x => x.Name.Contains(search) || x.PrintetName.Contains(search)).ToList();
            }
            catch (Exception)
            {
                return new List<TBCategory>();
            }

        }

        public List<TBCategory> SearchAllByUserId(int userId, string search)
        {
            try
            {
                return _context.Categoroy.Where(x => x.ID == userId).Where(x => x.Name.Contains(search) || x.PrintetName.Contains(search)).ToList();
            }
            catch (Exception)
            {
                return new List<TBCategory>();
            }

        }
        public string Update(TBCategory table)
        {
            try
            {
                _context = new AppDBContext();
                _context.Categoroy.Update(table);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return $"Error: {ex.Message}";
            }
        }
    }
}
