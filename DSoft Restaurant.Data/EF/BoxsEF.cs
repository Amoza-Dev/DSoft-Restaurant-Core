using DSoft_Restaurant.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class BoxsEF : IDataHelper<TBBoxs>
    {
        private AppDBContext context;
        private TBBoxs boxs;
        public BoxsEF()
        {
            context =new AppDBContext();
            boxs = new TBBoxs();    
        }

        public string Add(TBBoxs table)
        {
            try
            {
                context.Boxs.Add(table);
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
                boxs = Find(id);
                context.Boxs.Remove(boxs);
                context.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public TBBoxs Find(int id)
        {
            try
            {
                return context.Boxs.Find(id) ?? new TBBoxs();
            }
            catch (Exception)
            {
                return new TBBoxs();
            }
        }

        public List<TBBoxs> GetAll()
        {
            try
            {
                return context.Boxs.Where(x => !x.IsDelete).ToList();
            }
            catch (Exception)
            {
                return new List<TBBoxs>();
            }
        }

        public List<TBBoxs> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool IsCanConnect()
        {
            return context.Database.CanConnect();
        }

        public List<TBBoxs> SearchAll(string search)
        {
            throw new NotImplementedException();
        }

        public List<TBBoxs> SearchAllByUserId(int userId, string search)
        {
            throw new NotImplementedException();
        }

        public string Update(TBBoxs table)
        {
            try
            {
                context = new AppDBContext();
                context.Boxs.Update(table);
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
