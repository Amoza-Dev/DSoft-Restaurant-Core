using DSoft_Restaurant.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class ZonesEF : IDataHelper<TBZones>
    {
        private AppDBContext _context;
        private TBZones _zones;
        public ZonesEF()
        {
            _context = new AppDBContext();
            _zones = new TBZones();
        }
        public string Add(TBZones table)
        {
            try
            {
                _context.Zones.Add(table);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: { ex.Message}";
            }
        }

        public string Delete(int id)
        {
            try
            {
                _zones = Find(id);
                _context.Zones.Remove(_zones);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public TBZones Find(int id)
        {
            try
            {
                return _context.Zones.Find(id) ?? new TBZones();
            }
            catch (Exception)
            {
                return new TBZones();
            }
        }

        public List<TBZones> GetAll()
        {
            try
            {
                return _context.Zones.Where(x => !x.IsDelete).ToList();
            }
            catch (Exception)
            {
                return new List<TBZones>();
            }
        }

        public List<TBZones> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool IsCanConnect()
        {
            return _context.Database.CanConnect();
        }

        public List<TBZones> SearchAll(string search)
        {
            throw new NotImplementedException();
        }

        public List<TBZones> SearchAllByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }
        public string Update(TBZones table)
        {
            try
            {
                _context = new AppDBContext();
                _context.Zones.Update(table);
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
