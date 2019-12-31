using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifyDSL.DL
{
    class ShopifySalesDSL
    {
        public static DataSet GetSalesDL(string ShowIdBill)
        {
            string sql = "";

            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet sales = null;

            try
            {
                sql = "Select * from SalesHistory where SalesID = '" + ShowIdBill + "'";
                //  sql = "Select * from AddressDetails where name like '" + likeName + "%'";

                con = DBHelper.GetConnection();
                con.Open();

                sales = new DataSet();

                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(sales);
            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : ShopifyItemsDSL.cs:GetSalesDL:" + exe.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return sales;
        }



        public static int SaleEachInsertDL(ShopifyItems shopifyItems)
        {
            int output = 0;
            string sql = "";

            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {


                sql = "INSERT INTO SalesHistory(SalesID,ProductID,UnitPrice,Quantity,Date,TotalPrice) values(";
                sql = sql + "'" + shopifyItems.Salesid + "',";
                sql = sql + "'" + shopifyItems.Productid + "',";
                sql = sql + shopifyItems.Unitprice + ",";
                sql = sql + shopifyItems.Quantity + ",";
                sql = sql + shopifyItems.Salesdate + ",";
                sql = sql + "'" + shopifyItems.TotalSale + "')";

                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();

            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : ShopifyItemsDSL.cs:SaleEachInsertDL:" + exe.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }


        public static double GetTotalSaleDL(string SalesID)
        {
            string sql = "";

            SqlConnection con = null;
            SqlCommand cmd = null;


            SqlDataAdapter adapter = null;
            DataSet dsSales = null;
            string total = null;
            Object[] Data = null;


            try
            {

                sql = "Select SUM(TotalPrice) from SalesHistory where SalesID = '" + SalesID + "'";


                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);



                dsSales = new DataSet();

                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsSales);

                if (dsSales.Tables[0].Rows.Count > 0)
                {
                    Data = dsSales.Tables[0].Rows[0].ItemArray;
                    total = Data[0].ToString();
                    Console.Out.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa----------------" + Data[0].ToString());
                }

            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : ShopifyItemsDSL.cs:GetTotalSaleDL:" + exe.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return Convert.ToDouble(total);
        }


        public static int SalesInsertDL(ShopifyItems shopifyItems)
        {
            int output = 0;
            string sql = "";

            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "INSERT INTO Sales(SalesID,SalesDate,TransactionID,CustomerID,SalesTotal) values(";
                sql = sql + "'" + shopifyItems.Salesid + "',";
                sql = sql + "'" + shopifyItems.Salesdate + "',";
                sql = sql + "'trnID',";
                sql = sql + "'CumId',";
                sql = sql + "'" + shopifyItems.Total + "')";

                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();

            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : ShopifyItemsDSL.cs:SalesInsertDL:" + exe.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }



        public static String GetLastSalesIdDL()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsSales = null;
            string LastSalesId = null;
            Object[] Data = null;

            try
            {
                sql = "Select SalesID from sales order by SalesID desc";

                con = DBHelper.GetConnection();
                con.Open();

                dsSales = new DataSet();

                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsSales);

                if (dsSales.Tables[0].Rows.Count > 0)
                {
                    Data = dsSales.Tables[0].Rows[0].ItemArray;
                    LastSalesId = Data[0].ToString();
                }
            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : StudentMarkDao.cs:GetLastStudentId:" + exe.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return LastSalesId;
        }

    }
}
