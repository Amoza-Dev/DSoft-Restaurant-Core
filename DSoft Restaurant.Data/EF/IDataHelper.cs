using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public interface IDataHelper<Table>
    {
        //Read{Admin | Cashier}
        List<Table> GetAll();//Admin
        List<Table> GetAllByUserId(int userId);//Cashier
        List<Table> SearchAll(string search);//Admin
        List<Table> SearchAllByUserId(int userId, string search);//Cashier
        Table Find(int id);
        //Write
        string Add(Table table);//"1==>Success" ,Fail
        string Update(Table table);//"1==>Success" ,Fail   
        string Delete(int id);//"1==>Success" ,Fail

        //Other
        bool IsCanConnect();
    }
}
