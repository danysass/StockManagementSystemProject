
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StockManagment
{
    class SupplierService
    {
  

        public static DataTable _FullListDataTable = null;
        public static DataTable _FullActiveListDataTable = null;
        public static DataTable _DetailDataTable = null;
        public static DataTable _SubDetailDataTable = null;


        //Get
        public static DataTable GetFullList()
        {
            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {
               

                    con.ConnectionString = AAServerCon.GetServerConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT Id,Code,NameEN As Name, DetailsEN As Details ,IsActive FROM VLSupplier";
                    con.Open();
                    reader = cmd.ExecuteReader();
                    _FullListDataTable = new DataTable();
                    _FullListDataTable.Load(reader);
                
                return _FullListDataTable;
            }
            catch (Exception ex)
            {
                _FullListDataTable = null;
                AAServerCon._ErrorMessage = "Error :" + ex.Message;
                return null;
            }

            finally
            {

                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public static DataTable GetFullListActive()
        {
            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {
                if (_FullActiveListDataTable == null)
                {

                    con.ConnectionString = AAServerCon.GetServerConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;


                    cmd.CommandText = @"SELECT Id,Code,NameEN As Name, DetailsEN As Details ,IsActive  FROM VLSupplier where isActive=1";
                    con.Open();
                    reader = cmd.ExecuteReader();
                    _FullActiveListDataTable = new DataTable();
                    _FullActiveListDataTable.Load(reader);
                }
                return _FullActiveListDataTable;
            }
            catch (Exception ex)
            {
                _FullActiveListDataTable = null;
                AAServerCon._ErrorMessage = "Error :" + ex.Message;
                return null;
            }

            finally
            {

                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public static DataTable GetDetailById(int Id)
        {

            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {
                

                    con.ConnectionString = AAServerCon.GetServerConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT * FROM VLSupplier where Id=@Id ";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    _DetailDataTable = new DataTable();
                    _DetailDataTable.Load(reader);
                return _DetailDataTable;
            }
            catch (Exception ex)
            {
                _DetailDataTable = null;
                AAServerCon._ErrorMessage = "Error :" + ex.Message;
                return null;
            }

            finally
            {

                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }

        }

  

        public static bool GetDetailByCode(string _Code)
        {

            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {


                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT Code  FROM VLBuilding where Code=@Code";
                cmd.Parameters.AddWithValue("@Code", _Code);
                con.Open();
                reader = cmd.ExecuteReader();
              if(reader.HasRows)
                {
                return true;

                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception ex)
            {
                _DetailDataTable = null;
                AAServerCon._ErrorMessage = "Error :" + ex.Message;
                return false;
            }

            finally
            {

                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }

        }
        //POST Insert



        //string insertQuery = @"INSERT INTO VLSupplier (Code, NameEN, DetailsEN, IsActive, RegistrationNumber, 
        //                         AccountNumber, VatNumber, VatNote, CountryId, Address1, Address2, Phone1, 
        //                         Phone2, Cell, Fax, Website, Email, SortOrder, CreatedDate, CreatedBy, CreatedMachine) 
        //                         VALUES (@Code, @NameEN, @DetailsEN, @IsActive, @RegistrationNumber,
        //                         @AccountNumber, @VatNumber, @VatNote, @CountryId, @Address1, @Address2, @Phone1, 
        //                         @Phone2, @Cell, @Fax, @Website, @Email, @SortOrder, @CreatedDate, @CreatedBy, @CreatedMachine)"; 
                                

        public static int InsertRecord(string _Code,string _Name,string _Detail,bool _IsActive,int FKMain)
        {

            SqlConnection con = new SqlConnection();
            
            try
            {
                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO VLSupplier(Code, NameEN, DetailsEN, IsActive, RegistrationNumber,
                                 AccountNumber, VatNumber, VatNote, CountryId, Address1, Address2, Phone1,
                                 Phone2, Cell, Fax, Website, Email, SortOrder, CreatedDate, CreatedBy, CreatedMachine)
                                 VALUES(@Code, @NameEN, @DetailsEN, @IsActive, @RegistrationNumber,
                                 @AccountNumber, @VatNumber, @VatNote, @CountryId, @Address1, @Address2, @Phone1,
                                 @Phone2, @Cell, @Fax, @Website, @Email, @SortOrder, @CreatedDate, @CreatedBy, @CreatedMachine)"; 
                string query2 = "Select @@Identity";
                int ID;
                cmd.Parameters.AddWithValue("@Code", _Code);
                cmd.Parameters.AddWithValue("@NameEN", _Name);
                 cmd.Parameters.AddWithValue("@DetailsEN", _Detail);
                cmd.Parameters.AddWithValue("@IsActive", _IsActive);
                cmd.Parameters.AddWithValue("@RegistrationNumber", FKMain);
                cmd.Parameters.AddWithValue("@RegistrationNumber", FKMain);








                con.Open();
                cmd.ExecuteNonQuery();


                cmd.CommandText = query2;

                return ID = Convert.ToInt32( cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
               
                AAServerCon._ErrorMessage = "Error :" + ex.Message;
                return -1;
            }

            finally
            {

               
                if (con != null)
                {
                    con.Close();
                }
            }

        }

        //Set


        //Put//Update

        public static void UpdateRecord(string _Code, string _Name, string _Detail, bool _IsActive,int _Id , int FKMain)
        {

            SqlConnection con = new SqlConnection();

            try
            {


                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = @"update VLSupplier  set Code=@Code, NameEN=@NameEN , DetailsEN=@DetailsEN ,IsActive=@IsActive,FK_MainId=@FK_MainId where Id=@Id ";

                cmd.Parameters.AddWithValue("@Id", _Id);
                cmd.Parameters.AddWithValue("@Code", _Code);
                cmd.Parameters.AddWithValue("@NameEN", _Name);
                cmd.Parameters.AddWithValue("@DetailsEN", _Detail);
                cmd.Parameters.AddWithValue("@IsActive", _IsActive);
                cmd.Parameters.AddWithValue("@FK_MainId", FKMain);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                AAServerCon._ErrorMessage = "Error :" + ex.Message;

            }

            finally
            {


                if (con != null)
                {
                    con.Close();
                }
            }

        }

        //DELETE
        public static int DeleteRecordById(int Id)
        {

            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {


                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @" delete FROM VLSupplier  where Id=@Id ";
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                int x;
                x=cmd.ExecuteNonQuery();
                return x;
             
            }
            catch (Exception ex)
            {
                _DetailDataTable = null;
                AAServerCon._ErrorMessage = "Error :" + ex.Message;
                return 0;
            }

            finally
            {

                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }

        }


        //Supplier Items

        public static DataTable GetSupplierItemByItemid(int Id)
        {

            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {


                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT * FROM ItemSuppliers where ItemId=@Id ";
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                reader = cmd.ExecuteReader();
                _DetailDataTable = new DataTable();
                _DetailDataTable.Load(reader);
                return _DetailDataTable;
            }
            catch (Exception ex)
            {
                _DetailDataTable = null;
                AAServerCon._ErrorMessage = "Error :" + ex.Message;
                return null;
            }

            finally
            {

                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }

        }



    }
}
