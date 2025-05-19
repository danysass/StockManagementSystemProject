using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagment.Services
{
  public   class ValueListClass
    {

        public static DataTable GetFullList(string _TableName)
        {


            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {
                DataTable _FullListDataTable = new DataTable();

                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = @"SELECT Id,Code,NameEN As Name, DetailsEN As Details ,IsActive FROM " + _TableName + "";
                con.Open();
                reader = cmd.ExecuteReader();

                _FullListDataTable.Load(reader);

                return _FullListDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
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
        public static DataTable GetCurrencyList(string _TableName)
        {


            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {
                DataTable _FullListDataTable = new DataTable();

                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = @"SELECT Id,Code,NameEN As Name, DetailsEN As Details ,IsActive, CurencyRate FROM " + _TableName + "";
                con.Open();
                reader = cmd.ExecuteReader();

                _FullListDataTable.Load(reader);

                return _FullListDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
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
        public static DataTable GetFullList2(string _TableName)
        {


            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {
                DataTable _FullListDataTable = new DataTable();

                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = @"SELECT Id,Code,Name,IsActive FROM " + _TableName + "";
                con.Open();
                reader = cmd.ExecuteReader();

                _FullListDataTable.Load(reader);

                return _FullListDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
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
        public static DataTable GetMedicalProcedure()
        {


            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {
                DataTable _FullListDataTable = new DataTable();

                con.ConnectionString = AAServerCon.GetServerConnection2();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = @"SELECT Id,ProcedureName As Name FROM MedProcedure";
                con.Open();
                reader = cmd.ExecuteReader();

                _FullListDataTable.Load(reader);

                return _FullListDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
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
       static DataTable   _UsersListDataTable = null;
        public static DataTable GetUsers()
        {


            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            try
            {
                if (_UsersListDataTable == null)
                {
                    _UsersListDataTable = new DataTable();
                
                

                con.ConnectionString = AAServerCon.GetServerConnection2();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = @"SELECT Id,Name As Name FROM Users";
                con.Open();
                reader = cmd.ExecuteReader();

                _UsersListDataTable.Load(reader);
}
                return _UsersListDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
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

        public static string GenerateIndexCode(string prefix)
        {
            try
            {

                string newcodenumber;
                string examcode = "";
                string newcodestring = prefix + "0000000000";
                string mystring;
                string number2 = "1";
                int number;
                int codelenght;
                SqlConnection con = new SqlConnection();
                con.ConnectionString =AAServerCon. GetServerConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select indexnumber  from indextable where indexprecode='" + prefix + "' ";


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        examcode = reader.GetString(0);
                    }
                    reader.Close();
                    con.Close();
                    codelenght = examcode.Length;
                    mystring = number2 + examcode.Substring(2, codelenght - 2);
                    number = Convert.ToInt32(mystring);
                    number = number + 1;
                    newcodenumber = Convert.ToString(number);
                    newcodestring = prefix + newcodenumber.Substring(1, codelenght - 2);

                    SqlConnection Ucon = new SqlConnection();
                    Ucon.ConnectionString = AAServerCon.GetServerConnection();
                    Ucon.Open();
                    SqlCommand Ucmd = new SqlCommand();
                    Ucmd.Connection = Ucon;
                    Ucmd.CommandType = CommandType.Text;
                    Ucmd.CommandText = "update indextable set indexnumber ='" + newcodestring + "'where indexprecode='" + prefix + "' ";

                    Ucmd.ExecuteNonQuery();
                    Ucon.Close();
                }
                else if (!reader.HasRows)
                {
                    examcode = prefix + "00000001";
                    //mystring = number2 + examcode.Substring(2, 10);
                    //number = Convert.ToInt32(mystring);
                    //number = number + 1;
                    //newcodenumber = Convert.ToString(number);
                    newcodestring = examcode;
                    SqlConnection Icon = new SqlConnection();
                    Icon.ConnectionString = AAServerCon.GetServerConnection();
                    Icon.Open();
                    SqlCommand Icmd = new SqlCommand();
                    Icmd.Connection = Icon;
                    Icmd.CommandType = CommandType.Text;
                    Icmd.CommandText = "insert into indextable (indexnumber,indexprecode) values ('" + newcodestring + "','" + prefix + "')";
                    Icmd.ExecuteNonQuery();
                    Icon.Close();
                }
                return (newcodestring);
            }
            catch
            {
                MessageBox.Show("Error Select index table");
                return null;
            }
        }
    }
}
