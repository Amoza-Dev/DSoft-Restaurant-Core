using DevExpress.XtraEditors;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using DSoft_Restaurant.GUI.Home.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSoft_Restaurant.GUI.Home.Box
{
    public partial class FRMDetailsBox : DevExpress.XtraEditors.XtraForm
    {
        private readonly FRMListBox MainForm;
        private readonly IDataHelper<TBBoxs> dataHelperBoxs;
        private readonly LoadDataHelper<TBBoxs> loadDataHelper;
        private readonly AppDBContext appDBContext;
        public bool IsUpdate = false;
        public int _ID;
        public FRMDetailsBox(FRMListBox MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;

            appDBContext = new AppDBContext();
            dataHelperBoxs = new BoxsEF();
            DTStart.DateTime = DateTime.Now;
            loadDataHelper = new LoadDataHelper<TBBoxs>(new BoxsEF());
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void ButSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidate())
                {
                    msgHelper.ShowRequiredFields();
                }
                else
                {
                    if (dataHelperBoxs.IsCanConnect())
                    {
                        TBBoxs table = new TBBoxs
                        {
                            BoxName = TxtBoxName.Text,
                            Value=TxtBoxValue.Value,
                            StartDate = DTStart.DateOnly,
                            IsDelete = false,
                        };
                        bool IsSuccess = false;
                        if (IsUpdate)
                        {
                            table.ID = _ID;
                            //Edit
                            IsSuccess = Edit(table);
                        }
                        else
                        {
                            //Save
                            IsSuccess = Add(table);
                        }
                        if (IsSuccess)
                        {
                            await loadDataHelper.LoadDataWithProjection(MainForm.gridControl1, this, dataHelperBoxs =>
                            dataHelperBoxs.Select(x => new
                            {
                                x.ID,
                                x.BoxName,
                                x.Value,
                                x.StartDate,
                            }));
                            await loadDataHelper.Suggestions(MainForm.searchControl, x => x.BoxName);
                            if (IsUpdate)
                            {
                                this.Close();
                            }
                            Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }
        private bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(TxtBoxName.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ButNew_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            ClearHelper.ClearInputs(groupControl1);
            IsUpdate = false;
            _ID = 0;
            DTStart.DateTime = DateTime.Now;
        }
        private void FRMDetailsBox_Load(object sender, EventArgs e)
        {
            if (dataHelperBoxs.IsCanConnect())
            {
                if (IsUpdate)
                {
                    //Fill Controls
                    SetDataForEdit();
                }

            }
            else
            {
                msgHelper.ShowServerError();
            }
        }
        private void SetDataForEdit()
        {
            var _BoxName = dataHelperBoxs.Find(_ID);
            if (_BoxName.ID > 0)
            {
                TxtBoxName.Text = _BoxName.BoxName;
                TxtBoxValue.Value = _BoxName.Value;
                DTStart.EditValue = _BoxName.StartDate;
            }
        }
        private bool Add(TBBoxs table)
        {
            try
            {
                bool Exists = appDBContext.Boxs.Any(x => x.BoxName == table.BoxName);
                if (!Exists)
                {
                    var Add = dataHelperBoxs.Add(table);
                    if (Add == "1")
                    {
                        msgHelper.ShowSuccessAdd();
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show(Add);
                        return false;
                    }
                }
                else
                {
                    msgHelper.ShowDuplicatedItems();
                    return false;
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
                return false;
            }
        }
        private bool Edit(TBBoxs table)
        {
            try
            {
                bool Exists = appDBContext.Boxs.Any(x => x.BoxName == table.BoxName && x.ID != table.ID);
                if (!Exists)
                {
                    var Edit = dataHelperBoxs.Update(table);
                    if (Edit == "1")
                    {
                        msgHelper.ShowSuccessAdd();
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show(Edit);
                        return false;
                    }
                }
                else
                {
                    msgHelper.ShowDuplicatedItems();
                    return false;
                }

            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
                return false;
            }
        }
    }
}