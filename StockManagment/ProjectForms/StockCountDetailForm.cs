using DevExpress.XtraBars;
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
    public partial class StockCountDetailForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public StockCountDetailForm()
        {
            InitializeComponent();
        }


        public int _Id { get; set; }
        DataTable DetailDatatable = null;
        private void GetItemList()
        {

            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                con.Open();
                string sql = @"select * from  StockCountDetail where PhysicalCountID=@FK_Id ";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@FK_Id", _Id);
                if (DetailDatatable == null)
                {
                    DetailDatatable = new DataTable();

                }
                else
                {
                    DetailDatatable.Rows.Clear();


                }

                SqlDataReader reader = cmd.ExecuteReader();
                DetailDatatable.Load(reader);
                this.ListGridControl.DataSource = DetailDatatable;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex.Message);

            }
            finally
            {


                if (con != null)
                {
                    con.Close();
                }
            }


        }


        private void InsertItem()
        {
            using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                try
                {

                connection.Open();
                   
                    string query = @"
                    INSERT INTO StockCountDetail 
                    (ItemID,PhysicalCountID,AvailableQuantityOnHand,PhysicalCount,Variation)
                    VALUES 
                    (@ItemID,@PhysicalCountID,@AvailableQuantityOnHand,@PhysicalCount,@Variation)";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        for (int i = 0; i < ItemListdatata.Rows.Count; ++i)
                        {
                        command.Parameters.AddWithValue("@ItemID", ItemListdatata.Rows[i]["Id"]);
                        command.Parameters.AddWithValue("@PhysicalCountID", _Id);
                        command.Parameters.AddWithValue("@AvailableQuantityOnHand", ItemListdatata.Rows[i]["QuantityOnHand"]);
                        command.Parameters.AddWithValue("@PhysicalCount", 0);
                        command.Parameters.AddWithValue("@Variation", 0);
                            command.ExecuteNonQuery();
                        command.Parameters.Clear();


                        }
                    
                    }

 connection.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                   

                }

        }

        private void InsertItemsDetails()
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }


        DataTable ItemListdatata = null;

        private void StockCountDetailForm_Shown(object sender, EventArgs e)
        {
            try
            {


                repositoryItemLookUpEdit1.DataSource = ItemService._FullListDataTable;
                repositoryItemLookUpEdit1.ValueMember = "Id";
                repositoryItemLookUpEdit1.DisplayMember = "NameEnglish";

                GetItemList();
                if(DetailDatatable.Rows.Count<=0)
                {


                    ItemListdatata = new DataTable();
                    ItemListdatata= ItemService.GetFullList();

                    InsertItem();
                    GetItemList();
                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex.Message);

            }
        }

        private void CloseBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                    try
                    {

                        connection.Open();

                        string query = @"
                    update  StockCountDetail 
                    set PhysicalCount=@PhysicalCount,Variation=@Variation,Notes=@Notes where id=@id";


                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            for (int i = 0; i < ListGridView.RowCount; ++i)
                            {
                                command.Parameters.AddWithValue("@Id", ListGridView.GetRowCellValue(i,"Id"));
                                command.Parameters.AddWithValue("@PhysicalCount", ListGridView.GetRowCellValue(i, "PhysicalCount"));
                                command.Parameters.AddWithValue("@Variation", ListGridView.GetRowCellValue(i, "Variation"));
                               command.Parameters.AddWithValue("@Notes", ListGridView.GetRowCellValue(i, "Notes"));
                                command.ExecuteNonQuery();
                                command.Parameters.Clear();


                            }

                        }

                        connection.Close();
                        GetItemList();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);


                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}