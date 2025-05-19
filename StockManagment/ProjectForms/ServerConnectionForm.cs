using DevExpress.XtraEditors;
using StockManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagment
{
    public partial class ServerConnectionForm : DevExpress.XtraEditors.XtraForm
    {
        public ServerConnectionForm()
        {
            InitializeComponent();

            ServerNameTextEdit.Text = AAServerCon.serverIP;
            UserNameTextEdit.Text = AAServerCon.serverUserName;
            PasswordTextEdit.Text = AAServerCon.serverPassword;
            DatabaseTextEdit.Text = AAServerCon.serverDefaultDB;
            IntegratedSecurityComboBoxEdit.Text = Convert.ToString(AAServerCon.Integrated_Security);
            MDCDBTextEdit.Text = AAServerCon.serverDefaultDB2;
            //ReportPathTextEdit.Text = AAServerCon.ReportPath;
        }

        

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            updateServerconnection();
            this.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        string StockConnectionString = ConfigurationManager.ConnectionStrings["StockConnection"].ConnectionString;
        string MDCConnectionString = ConfigurationManager.ConnectionStrings["MDCConnection"].ConnectionString;
        private bool CheckStockServerConnection()
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(StockConnectionString))
                {
                    try
                    {
                        connection.Open();
                        return true;


                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error connecting to database: " + ex.Message);
                        return false;

                    }
                }






            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
        private bool CheckMDCServerConnection()
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(MDCConnectionString))
                {
                    try
                    {
                        connection.Open();
                        return true;


                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error connecting to database: " + ex.Message);
                        return false;

                    }
                }






            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
        private void updateServerconnection()
        {
            try
            {
                UpdateConnectionString(
                "StockConnection", "Data Source=" + ServerNameTextEdit.Text + "; Initial Catalog=" + DatabaseTextEdit.Text + "; User Id=" + UserNameTextEdit.Text + ";Password=" + PasswordTextEdit.Text + ";Persist Security Info=false;");
                UpdateConnectionString(
    "MDCConnection","Data Source=" + ServerNameTextEdit.Text + "; Initial Catalog=" + MDCDBTextEdit.Text + "; User Id=" + UserNameTextEdit.Text + ";Password=" + PasswordTextEdit.Text + ";Persist Security Info=false;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateConnectionString(string name, string newConnectionString)
        {
            try
            {
                // Open App.config of executable
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                // Retrieve the connection string settings
                ConnectionStringSettings settings = config.ConnectionStrings.ConnectionStrings[name];
                // If the connection string exists, update it
                if (settings != null)
                {
                    settings.ConnectionString = newConnectionString;
                }
                else
                {
                    // If the connection string does not exist, create it
                    config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(name, newConnectionString));
                }

                // Save the changes in App.config file
                config.Save(ConfigurationSaveMode.Modified);

                // Force a reload of the changed section
                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("Connection string updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating connection string: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ServerConnectionForm_Shown(object sender, EventArgs e)
        {
            try
            {

                if (CheckStockServerConnection())
                {




                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(StockConnectionString);
                    string serverName = builder.DataSource;
                    string pass = builder.Password;
                    string userid = builder.UserID;
                    string db = builder.InitialCatalog;
                    bool secur = builder.IntegratedSecurity;
                    
                    AAServerCon.serverIP = serverName;
                    AAServerCon.serverUserName = userid;
                    AAServerCon.serverPassword = pass;
                    AAServerCon.serverDefaultDB = db;
                    AAServerCon.Integrated_Security = secur;
                   
                    ServerNameTextEdit.Text = AAServerCon.serverIP;
                    UserNameTextEdit.Text = AAServerCon.serverUserName;
                    PasswordTextEdit.Text = AAServerCon.serverPassword;
                    DatabaseTextEdit.Text = AAServerCon.serverDefaultDB;
                    IntegratedSecurityComboBoxEdit.Text = Convert.ToString(AAServerCon.Integrated_Security);



                }
                else
                {
                    MessageBox.Show("No Connection With Stock DB");
                }

                if (CheckMDCServerConnection())
                {




                    SqlConnectionStringBuilder builder2 = new SqlConnectionStringBuilder(MDCConnectionString);
                 
                    string db = builder2.InitialCatalog;
                   

                    
                    AAServerCon.serverDefaultDB2 = db;
                    

                  MDCDBTextEdit.Text=AAServerCon.serverDefaultDB2;



                }
                else
                {
                    MessageBox.Show("No Connection With MDC DB");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}