using DSoft_Restaurant.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class ItemsEF : IDataHelper<TBItems>
    {
        private AppDBContext _context;
        private TBItems _items;

        public ItemsEF()
        {
            _context = new AppDBContext();
            _items = new TBItems();
        }
        public string Add(TBItems table)
        {
            try
            {
                _context.Items.Add(table);
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
                _items = Find(id);
                _context.Items.Remove(_items);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public TBItems Find(int id)
        {
            try
            {
                return _context.Items.Find(id) ?? new TBItems();
            }
            catch (Exception ex)
            {
                return new TBItems();
            }
        }

        public List<TBItems> GetAll()
        {
            try
            {
                return _context.Items.Include(x => x.tBCategory).ToList();
            }
            catch (Exception)
            {
                return new List<TBItems>();
            }
        }

        public List<TBItems> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool IsCanConnect()
        {
            return _context.Database.CanConnect();
        }

        public List<TBItems> SearchAll(string search)
        {
            try
            {
                return _context.Items.Where(x => x.Name.Contains(search)).ToList();

            }
            catch (Exception)
            {
                return new List<TBItems>();
            }
        }

        public List<TBItems> SearchAllByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }
        public string Update(TBItems table)
        {
            try
            {
                _context = new AppDBContext();
                _context.Items.Update(table);
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
