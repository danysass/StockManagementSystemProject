
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockManagment
{
    public class AAServerCon
    {


        public static string serverIP { get; set; } = @"localhost";
        public static string serverUserName { get; set; } = "clemed";
        public static string serverPassword { get; set; } = "Clemed@123$";
        public static string serverDefaultDB { get; set; } = "StockDB";
        public static bool Integrated_Security { get; set; } = true;
        public static string serverDefaultDB2 { get; set; } = "MDC2024";




        //public static string serverIP { get; set; } = @"server3\act";
        //public static string serverUserName { get; set; } = "sa";
        //public static string serverPassword { get; set; } = "P@ssw0rd";
        //public static string serverDefaultDB { get; set; } = "StockDB";
        //public static string serverDefaultDB2 { get; set; } = "MDC2025";
        //public static bool Integrated_Security { get; set; } = false;
        public static string _ErrorMessage;
        public static string GetServerConnection()
        {
            try
            {
                //string Connectionstring = @"Data Source=" + serverIP + ";Initial Catalog=" + serverDefaultDB + ";User ID=" + serverUserName + ";Password=" + serverPassword + ";Connection Timeout=120;Max Pool Size=500;Min Pool Size=5 ;Encrypt=false";
                string Connectionstring = @"Data Source=" + serverIP + ";Initial Catalog=" + serverDefaultDB + ";User ID=" + serverUserName + ";Password=" + serverPassword + ";Connection Timeout=120;Max Pool Size=500;Min Pool Size=5 ;Integrated Security="+ Integrated_Security+"; Encrypt=false";
                return Connectionstring;
            }
            catch (Exception ex)
            {   return "Error In Connection";
                throw new Exception(ex.ToString());
            }
        }

        public static string GetServerConnection2()
        {
            try
            {
                //string Connectionstring = @"Data Source=" + serverIP + ";Initial Catalog=" + serverDefaultDB + ";User ID=" + serverUserName + ";Password=" + serverPassword + ";Connection Timeout=120;Max Pool Size=500;Min Pool Size=5 ;Encrypt=false";
                string Connectionstring = @"Data Source=" + serverIP + ";Initial Catalog=" + serverDefaultDB2 + ";User ID=" + serverUserName + ";Password=" + serverPassword + ";Connection Timeout=120;Max Pool Size=500;Min Pool Size=5 ;Integrated Security=" + Integrated_Security + "; Encrypt=false";
                return Connectionstring;
            }
            catch (Exception ex)
            {
                return "Error In Connection";
                throw new Exception(ex.ToString());
            }
        }
    }
}
