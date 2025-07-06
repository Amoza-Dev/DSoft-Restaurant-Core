using DSoft_Restaurant.Core.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class DeliverCompanyEF : IDataHelper<TBDeliveryCompany>
    {
        private AppDBContext _context;
        private TBDeliveryCompany _deliveryCompany;
        public DeliverCompanyEF()
        {
            _context = new AppDBContext();  
            _deliveryCompany = new TBDeliveryCompany(); 
        }

        public string Add(TBDeliveryCompany table)
        {
            try
            {
                _context.DeliveryCompany.Add(table);
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
                _deliveryCompany=Find(id);
                _context.DeliveryCompany.Remove(_deliveryCompany);
                _context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public TBDeliveryCompany Find(int id)
        {
            try
            {
                return _context.DeliveryCompany.Find(id) ?? new TBDeliveryCompany();
            }
            catch (Exception ex)
            {
                return new TBDeliveryCompany();
            }
        }

        public List<TBDeliveryCompany> GetAll()
        {
            try
            {
                return _context.DeliveryCompany.Where(x => x.IsDelete == false).ToList();
            }
            catch (Exception ex)
            {
                return new List<TBDeliveryCompany>();
            }
        }

        public List<TBDeliveryCompany> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool IsCanConnect()
        {
            return _context.Database.CanConnect();
        }

        public List<TBDeliveryCompany> SearchAll(string search)
        {
            try
            {
                return _context.DeliveryCompany.Where(x => x.Name.Contains(search)).ToList();
            }
            catch (Exception ex)
            {
                return new List<TBDeliveryCompany>();
            }
        }

        public List<TBDeliveryCompany> SearchAllByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }

        public List<TBDeliveryCompany> SuggestionByName(string search)
        {
            try
            {
                _context = new AppDBContext();
                return _context.DeliveryCompany
                         .Where(c => c.Name.Contains(search))
                         .OrderBy(c => c.Name)
                         .ToList();

            }
            catch (Exception ex)
            {
                return new List<TBDeliveryCompany>(); // یان null پێشنیار ناکرێت
            }
        }

        public List<TBDeliveryCompany> SuggestionsByNameByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }

        public string Update(TBDeliveryCompany table)
        {
            try
            {
                _context =new AppDBContext();
                _context.DeliveryCompany.Update(table);
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
