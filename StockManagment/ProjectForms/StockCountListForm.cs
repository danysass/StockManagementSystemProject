using DevExpress.Data.Filtering;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using StockManagment.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagment.ProjectForms
{
    public partial class StockCountListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public StockCountListForm()
        {
            InitializeComponent();
        }
        public int Id { get; set; } = 0;
        private void ExitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private DataTable HeadDataTable = null;
        private DataTable Gethead()
        {
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                con.Open();
                string sql = @"select * from StockCountHead";
               

                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                HeadDataTable = new DataTable();
                HeadDataTable.Load(reader);
                reader.Close();
                con.Close();
                return HeadDataTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private void PurchaseOrderListForm_Shown(object sender, EventArgs e)
        {
            try
            {

                repositoryItemLookUpEdit1.DataSource = ValueListClass.GetFullList("VLWarehouse");
                repositoryItemLookUpEdit1.ValueMember = "Id";
                repositoryItemLookUpEdit1.DisplayMember = "Name";

                Gethead();
                ListGridControl.DataSource = HeadDataTable;


               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ListGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                
                if(ListGridView.RowCount>0)
                {

                    if (ListGridView.IsGroupRow(ListGridView.FocusedRowHandle))
                    {
                        return;
                    }
                    if (ListGridView.FocusedRowHandle < -1)
                    {

                        return;
                    }

                    int id = Convert.ToInt32(ListGridView.GetRowCellValue(ListGridView.FocusedRowHandle, "Id"));

                    StockCountForm FormDetail = new StockCountForm();
                    FormDetail._Id = id;
                    FormDetail.record = StockCountForm.RecordFlag.Edit;
                    FormDetail.ShowDialog();
                    Gethead();
                    ListGridControl.DataSource = HeadDataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TodayOrderBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ListGridView.ActiveFilterString = string.Empty;
                ListGridView.SetAutoFilterValue(OrderDateColum, DateTime.Today, DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Last30DaysBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ListGridView.ActiveFilterString = string.Empty;
                //DayOfWeek day = DateTime.Now.DayOfWeek;
                //int days = day - DayOfWeek.Sunday;
                //DateTime start = DateTime.Now.AddDays(-days);
                //DateTime end = start.AddDays(7);

                DateTime start = DateTime.Today.AddMonths(-1);
                DateTime end = DateTime.Today.AddDays(1);






                BinaryOperator op1 = new BinaryOperator("CountDate", start, BinaryOperatorType.GreaterOrEqual);
                BinaryOperator op2 = new BinaryOperator("CountDate", end, BinaryOperatorType.Less);
                ListGridView.ActiveFilterCriteria = new GroupOperator(GroupOperatorType.And, op1, op2);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AllDaysBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListGridView.ActiveFilterString = string.Empty;
        }

        private void Last3MonthBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ListGridView.ActiveFilterString = string.Empty;
                //DayOfWeek day = DateTime.Now.DayOfWeek;
                //int days = day - DayOfWeek.Sunday;
                //DateTime start = DateTime.Now.AddDays(-days);
                //DateTime end = start.AddDays(7);

                DateTime start = DateTime.Today.AddMonths(-3);
                DateTime end = DateTime.Today.AddDays(1);






                BinaryOperator op1 = new BinaryOperator("CountDate", start, BinaryOperatorType.GreaterOrEqual);
                BinaryOperator op2 = new BinaryOperator("CountDate", end, BinaryOperatorType.Less);
                ListGridView.ActiveFilterCriteria = new GroupOperator(GroupOperatorType.And, op1, op2);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Last6MonthBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ListGridView.ActiveFilterString = string.Empty;
                //DayOfWeek day = DateTime.Now.DayOfWeek;
                //int days = day - DayOfWeek.Sunday;
                //DateTime start = DateTime.Now.AddDays(-days);
                //DateTime end = start.AddDays(7);

                DateTime start = DateTime.Today.AddMonths(-3);
                DateTime end = DateTime.Today.AddDays(1);






                BinaryOperator op1 = new BinaryOperator("CountDate", start, BinaryOperatorType.GreaterOrEqual);
                BinaryOperator op2 = new BinaryOperator("CountDate", end, BinaryOperatorType.Less);
                ListGridView.ActiveFilterCriteria = new GroupOperator(GroupOperatorType.And, op1, op2);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ThisYearBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ListGridView.ActiveFilterString = string.Empty;
                //DayOfWeek day = DateTime.Now.DayOfWeek;
                //int days = day - DayOfWeek.Sunday;
                //DateTime start = DateTime.Now.AddDays(-days);
                //DateTime end = start.AddDays(7);
    
                DateTime start = new DateTime(DateTime.Now.Year, 1, 1);
                DateTime end = DateTime.Today.AddDays(1);






                BinaryOperator op1 = new BinaryOperator("CountDate", start, BinaryOperatorType.GreaterOrEqual);
                BinaryOperator op2 = new BinaryOperator("CountDate", end, BinaryOperatorType.Less);
                ListGridView.ActiveFilterCriteria = new GroupOperator(GroupOperatorType.And, op1, op2);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GroupBySupplierBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ListGridView.OptionsBehavior.AutoExpandAllGroups = false;
                foreach (DevExpress.XtraGrid.Columns.GridColumn c in ListGridView.Columns)
                {

                    c.GroupIndex = -1;

                }
                ColSupplier.GroupIndex = 10;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GroupByDateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ListGridView.OptionsBehavior.AutoExpandAllGroups = false;
                foreach (DevExpress.XtraGrid.Columns.GridColumn c in ListGridView.Columns)
                {

                    c.GroupIndex = -1;

                }
                OrderDateColum.GroupIndex = 10;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UngroupBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ListGridView.OptionsBehavior.AutoExpandAllGroups = false;
                foreach (DevExpress.XtraGrid.Columns.GridColumn c in ListGridView.Columns)
                {

                    c.GroupIndex = -1;

                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ListGridView.ShowPrintPreview();
        }
    }
}