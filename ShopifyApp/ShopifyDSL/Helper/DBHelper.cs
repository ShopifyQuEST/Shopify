using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace ShopifyDSL.Helper
{
    class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = null;


            try
            {

                String connectionstring = ConfigurationManager.ConnectionStrings["ShopifyApp.Properties.Settings.StockItemsConnectionString"].ConnectionString;

                con = new SqlConnection(connectionstring); //connection with db
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : DBHelper.cs " + e3.Message.ToString());
            }

            return con;

        }
    }
        
}
