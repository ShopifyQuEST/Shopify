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
                sql = " insert into  StockDetails(ProductID,ProductName,UnitPrice,Quantity) VALUES (";
                sql = sql + "'" + shopifyItems.Productid + "',";
                sql = sql + "'" + shopifyItems.Productname + "',";

                sql = sql + "" + shopifyItems.Unitprice + ",";
                //sql = sql + "'" + shopifyItems.Quantity + "',";

                sql = sql + " " + shopifyItems.Quantity + ")";

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





        public static int StockUpdate(ShopifyItems shopifyItems)
        {
            int output = 0;
            string sql = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = " update  StockDetails set ";
                //sql = sql + "Description='" + pocketMoney.Description + "',";
                // sql = sql + "Transaction_type='" + pocketMoney.Transaction + "',";
                sql = sql + "Quantity=" + shopifyItems.Quantity + ",";
                sql = sql + "UnitPrice=" + shopifyItems.Unitprice + "";


                sql = sql + " where ProductID=" + shopifyItems.Productid + " ";

                ////////////
                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();

            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : AddressDSL.cs:StockUpdate " + e3.Message.ToString());


            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }









        public static ShopifyItems GetByID(string productId)
        {
            String sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;

            DataSet dsSTudents = null;
            ShopifyItems shopifyItems = null;

            try
            {
                sql = "select * from StockDetails where ProductID='" + productId + "'";
                con = DBHelper.GetConnection();
                con.Open();
                dsSTudents = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsSTudents);
                object[] Data = null;
                if (dsSTudents.Tables[0].Rows.Count > 0)
                {
                    Data = dsSTudents.Tables[0].Rows[0].ItemArray;
                    shopifyItems = new ShopifyItems();
                    shopifyItems.Productid = Data[0].ToString();
                    shopifyItems.Productname = Data[1].ToString();
                    shopifyItems.Unitprice = Convert.ToInt32(Data[2]);
                    shopifyItems.Quantity = Convert.ToInt32(Data[3]);
                    




                }
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : AddressDSL.cs :GetStudentById()" + e3.Message.ToString());


            }
            finally
            {
                con.Close();

            }
            return shopifyItems;
        }


        public static DataSet GetContactIDs()
        {
            String sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;

            DataSet dsSTudents = null;

            try
            {
                sql = "select ProductID from StockDetails";
                con = DBHelper.GetConnection();
                con.Open();
                dsSTudents = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsSTudents);
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : AddressDSL.cs:GetContactIDs()" + e3.Message.ToString());


            }
            finally
            {
                con.Close();

            }
            return dsSTudents;
        }





        public static int DeleteItem(string id)
        {
            int output = 0;
            string sql = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                //sql = " delete from PocketMoney where =Sr_no" + id + "'";
                sql = " delete from StockDetails where ProductID='" + id + "'";
                ////////////
                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();

            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyDSL.cs " + e3.Message.ToString());


            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }



        public static DataSet GetDetails()
        {
            String sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;

            DataSet dsSTudents = null;

            try
            {
                sql = "select * from StockDetails";
                con = DBHelper.GetConnection();
                con.Open();
                dsSTudents = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsSTudents);
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyDSL.cs: GetDetails()" + e3.Message.ToString());


            }
            finally
            {
                con.Close();

            }
            return dsSTudents;
        }

    }
}

    

