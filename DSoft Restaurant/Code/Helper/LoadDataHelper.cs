using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraSplashScreen;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using DSoft_Restaurant.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Code.Helper
{
    public class LoadDataHelper<T>  where T : class
    {
        public IDataHelper<T> DataHelper { get; set; }
        public LoadDataHelper(IDataHelper<T> dataHelper)
        {
            DataHelper = dataHelper;
        }
        public async Task LoadData(GridControl gridControl, XtraForm frm)
        {
            SplashScreenManager.ShowForm(frm, typeof(WaitForm1), true, true, false);
            try
            {
                if (await Task.Run(() => DataHelper.IsCanConnect()))
                {
                    var data = await Task.Run(() => DataHelper.GetAll());
                    gridControl.DataSource = data;
                }
                else
                {
                    msgHelper.ShowServerError();
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }
        public async Task LoadDataWithProjection(GridControl gridControl, XtraForm frm, Func<IEnumerable<T>, IEnumerable<object>> projection)
        {
            try
            {
                SplashScreenManager.ShowForm(frm, typeof(WaitForm1), true, true, false);
                if (await Task.Run(() => DataHelper.IsCanConnect()))
                {
                    var rawData = await Task.Run(() => DataHelper.GetAll());
                    var projected = await Task.Run(() => projection(rawData));
                    gridControl.DataSource = projected.ToList();
                }
                else
                {
                    msgHelper.ShowServerError();
                }
            }

            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        public async Task Suggestions(SearchControl searchControl, Func<T, string> nameSelector)
        {
            var suggestions = await Task.Run(() => DataHelper.GetAll().Select(nameSelector).ToList());

            searchControl.Properties.Items.BeginUpdate();
            searchControl.Properties.Items.Clear();
            searchControl.Properties.Items.AddRange(suggestions);
            searchControl.Properties.Items.EndUpdate();
        }
    }
}
