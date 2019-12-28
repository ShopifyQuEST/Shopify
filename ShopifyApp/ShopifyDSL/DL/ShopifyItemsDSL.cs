using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifyDTO.DTO;
using System.Data.SqlClient;
using System.Data;
using ShopifyDSL.Helper;

namespace ShopifyDSL.DL
{
   public class ShopifyItemsDSL
    {


        public static int StockInsert(ShopifyItems shopifyItems)
        {
            int output = 0;
            string sql = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = " insert into  StockDetails(ProductID,ProductName) VALUES (";
                sql = sql + "'" + shopifyItems.Productid + "',";
                sql = sql + "'" + shopifyItems.Productname + "')";

               // sql = sql + "" + shopifyItems.Unitprice + ",";
               //// sql = sql + "'" + shopifyItems.Quantity + "',";

               //sql = sql +" " + shopifyItems.Quantity + ")";

                //sql = sql + "'" + addressBook.Email + "')";
                //sql = sql + "'" + studentMARK.Result + "')";


                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR :ShopifyItemsDSL.cs:StockInsert() " + e3.Message.ToString());


            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }




    }
}
