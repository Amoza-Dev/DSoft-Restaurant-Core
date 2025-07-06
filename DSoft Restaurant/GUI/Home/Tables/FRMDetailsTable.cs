using DevExpress.CodeParser;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSoft_Restaurant.GUI.Home.Tables
{
    public partial class FRMDetailsTable : DevExpress.XtraEditors.XtraForm
    {
        private readonly FRMListTables MainForm;
        private readonly IDataHelper<TBZones> dataHelperZone;
        private readonly IDataHelper<TBTables> dataHelperTables;
        private readonly AppDBContext appDBContext;
        private readonly LoadDataHelper<TBTables> loadDataHelper;
        public int _ID = 0;
        public bool IsUpdate = false;
        public FRMDetailsTable(FRMListTables MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;

            appDBContext = new AppDBContext();
            dataHelperZone = new ZonesEF();
            dataHelperTables = new TablesEF();
            loadDataHelper = new LoadDataHelper<TBTables>(new TablesEF());
        }

        private async void FRMDetailsTable_Load(object sender, EventArgs e)
        {
            await FillComboBox();
            try
            {
                if (dataHelperTables.IsCanConnect())
                {
                    if (IsUpdate)
                    {
                        SetDataForEdit();
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private async Task FillComboBox()
        {
            try
            {
                if (dataHelperZone.IsCanConnect())
                {
                    var ListZones = await Task.Run(() => dataHelperZone.GetAll().Where(z => z.IsActive == true)
                    .Select(x => new { x.ZoneName, x.ID }).ToList());
                    CBZoneList.Properties.DataSource = ListZones;
                    CBZoneList.Properties.DisplayMember = "ZoneName";
                    CBZoneList.Properties.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            ClearHelper.ClearInputs(groupControl1);
            IsUpdate = false;
            _ID = 0;
            CBZoneList.EditValue = null;
        }
        private bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(TxtTableName.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool Add(TBTables table)
        {

            bool Exists = appDBContext.Tables.Any(t => t.Name == table.Name && t.ZoneID == table.ZoneID);
            if (!Exists)
            {
                var Success = dataHelperTables.Add(table);
                if (Success == "1")
                {
                    msgHelper.ShowSuccessAdd();
                    return true;
                }
                else
                {
                    XtraMessageBox.Show(Success);
                    return false;
                }
            }
            else
            {
                msgHelper.ShowDuplicatedItems();
                return false;
            }
        }
        private bool Edit(TBTables table)
        {
            bool Exists = appDBContext.Tables.Any(t => t.Name == table.Name && t.ZoneID == table.ZoneID && t.ID != table.ID);
            if (!Exists)
            {
                TBTables tables = new TBTables
                {
                    Name = TxtTableName.Text,
                    ZoneID = (int)CBZoneList.EditValue,
                    ID = _ID
                };
                var Success = dataHelperTables.Update(tables);
                if (Success == "1")
                {
                    msgHelper.ShowSuccessEdit();
                    return true;
                }
                else
                {
                    XtraMessageBox.Show(Success);
                    return false;
                }
            }
            else
            {
                msgHelper.ShowDuplicatedItems();
                return false;   
            }
        }
        private void SetDataForEdit()
        {
            var _tables = dataHelperTables.Find(_ID);
            if (_tables.ID > 0)
            {
                TxtTableName.Text = _tables.Name;
                CBZoneList.EditValue = _tables.ZoneID;
            }
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
                    if (dataHelperTables.IsCanConnect())
                    {
                        TBTables tables = new TBTables
                        {
                            Name = TxtTableName.Text,
                            ZoneID = (int)CBZoneList.EditValue,
                            IsDelete = false,
                        };
                        bool IsSuccess = false;

                        if (IsUpdate)
                        {
                            tables.ID = _ID;
                            //Edit
                            IsSuccess = Edit(tables);
                        }
                        else
                        {
                            //Save
                            IsSuccess = Add(tables);
                        }
                        if (IsSuccess) 
                        {
                            await loadDataHelper.LoadDataWithProjection(MainForm.gridControl1, this, dataHelperTables =>
                            dataHelperTables.Select(x => new
                            {
                                x.ID,
                                x.Name,
                                tablezone = x.TBZones.ZoneName
                            })
                            );
                            await loadDataHelper.Suggestions(MainForm.searchControl1, x => x.Name);
                            ClearHelper.ClearInputs(groupControl1);
                            if (IsUpdate)
                            {
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        msgHelper.ShowServerError();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}