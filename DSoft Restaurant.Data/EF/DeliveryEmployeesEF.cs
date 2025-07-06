using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class DeliveryEmployeesEF : IDataHelper<TBDeliveryEmployee>
    {
        private AppDBContext _context;
        private TBDeliveryEmployee _deliveryEmployee;
        public DeliveryEmployeesEF()
        {
            _context = new AppDBContext();
            _deliveryEmployee = new TBDeliveryEmployee();
        }

        public string Add(TBDeliveryEmployee table)
        {
            try
            {
                _context.DeliveryEmployees.Add(table);
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
                _deliveryEmployee = Find(id);
                _context.DeliveryEmployees.Remove(_deliveryEmployee);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public TBDeliveryEmployee Find(int id)
        {
            try
            {
                return _context.DeliveryEmployees.Find(id) ?? new TBDeliveryEmployee();
            }
            catch (Exception)
            {
                return new TBDeliveryEmployee();
            }
        }

        public List<TBDeliveryEmployee> GetAll()
        {
            try
            {
                return _context.DeliveryEmployees.Where(x => !x.IsDelete).ToList();
            }
            catch (Exception)
            {
                return new List<TBDeliveryEmployee>();
            }
        }

        public List<TBDeliveryEmployee> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool IsCanConnect()
        {
            return _context.Database.CanConnect();
        }

        public List<TBDeliveryEmployee> SearchAll(string search)
        {
            throw new NotImplementedException();
        }

        public List<TBDeliveryEmployee> SearchAllByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }

        public string Update(TBDeliveryEmployee table)
        {
            try
            {
                _context = new AppDBContext();
                _context.DeliveryEmployees.Update(table);
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
