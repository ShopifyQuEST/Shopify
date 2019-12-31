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



        //Method for stock insert in DSL

        public static int StockInsert(ShopifyItems shopifyItems)
        {
            int output = 0;
            string sql = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = " insert into  StockDetails(ProductID,ProductName,UnitPrice,Quantity,SupplierID,Date) VALUES (";
                sql = sql + "'" + shopifyItems.Productid + "',";
                sql = sql + "'" + shopifyItems.Productname + "',";
                sql = sql + "" + shopifyItems.Unitprice + ",";         
                sql = sql + "" + shopifyItems.Quantity + ",";
                sql = sql + "'" + shopifyItems.Supplierid + "',";
                sql = sql + "'" + shopifyItems.Date + "')";


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
         
                sql = sql + "Quantity=" + shopifyItems.Quantity + ",";
                sql = sql + "UnitPrice=" + shopifyItems.Unitprice + ",";
                sql = sql + "SupplierID='" + shopifyItems.Supplierid + "'";


                sql = sql + " where ProductID=" + shopifyItems.Productid + " ";

              
                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();

            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsDSL.cs:StockUpdate " + e3.Message.ToString());


            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }


        //update supplier


        public static int SupplierUpdate(SupplierData supplierData)
        {
            int output = 0;
            string sql = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = " update  SupplierDetails set ";
                //sql = sql + "Description='" + pocketMoney.Description + "',";
                // sql = sql + "Transaction_type='" + pocketMoney.Transaction + "',";
                sql = sql + "SupplierName='" + supplierData.SupplierName + "',";
                sql = sql + "ContactNumber=" + supplierData.ContactNumber + "";
                


                sql = sql + " where SupplierID=" + supplierData.SupplierId + " ";

                ////////////
                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();

            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsDSL.cs:StockUpdate " + e3.Message.ToString());


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
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsDSL.cs :GetByID()" + e3.Message.ToString());


            }
            finally
            {
                con.Close();

            }
            return shopifyItems;
        }





        public static SupplierData GetBySupplierID(string supplierid)
        {
            String sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;

            DataSet dsSTudents = null;
            SupplierData supplierData = null;

            try
            {
                sql = "select * from SupplierDetails where SupplierID='" + supplierid + "'";
                con = DBHelper.GetConnection();
                con.Open();
                dsSTudents = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsSTudents);
                object[] Data = null;
                if (dsSTudents.Tables[0].Rows.Count > 0)
                {
                    Data = dsSTudents.Tables[0].Rows[0].ItemArray;
                    supplierData = new SupplierData();
                    supplierData.SupplierId = Data[0].ToString();
                    supplierData.SupplierName = Data[1].ToString();
                    supplierData.ContactNumber = Convert.ToInt32(Data[2]);
                    supplierData.Desciption = Data[3].ToString();





                }
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsDSL.cs :GetBySupplierID()" + e3.Message.ToString());


            }
            finally
            {
                con.Close();

            }
            return supplierData;
        }


        public static DataSet GetProductID()
        {
            String sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;

            DataSet dsStockID = null;

            try
            {
                sql = "select ProductID from StockDetails";
                con = DBHelper.GetConnection();
                con.Open();
                dsStockID = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsStockID);
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsDSL.cs:GetContactIDs()" + e3.Message.ToString());


            }
            finally
            {
                con.Close();

            }
            return dsStockID;
        }

        //load supplier id


        public static DataSet GetSupplierIDs()
        {
            String sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;

            DataSet dsSuppliers = null;

            try
            {
                sql = "select SupplierID from SupplierDetails";
                con = DBHelper.GetConnection();
                con.Open();
                dsSuppliers = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsSuppliers);
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsDSL.cs:GetSupplierIDs()" + e3.Message.ToString());


            }
            finally
            {
                con.Close();

            }
            return dsSuppliers;
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
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsDSL.cs:DeleteItem()" + e3.Message.ToString());


            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }



        public static int DeletingItem(string id)
        {
            int output = 0;
            string sql = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                //sql = " delete from Supplier where =Sr_no" + id + "'";
                sql = " delete from SupplierDetails where SupplierID='" + id + "'";
                ////////////
                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();

            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsDSL.cs:DeletingItem() " + e3.Message.ToString());


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








        public static int SupplierAdd(SupplierData supplierData)
        {
            int output = 0;
            string sql = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = " insert into  SupplierDetails(SupplierID,SupplierName,ContactNumber,Description) VALUES (";
                sql = sql + "'" + supplierData.SupplierId + "',";
                sql = sql + "'" + supplierData.SupplierName + "',";

                sql = sql + "" + supplierData.ContactNumber + ",";
                //sql = sql + "'" + shopifyItems.Quantity + "',";

                sql = sql + "'" + supplierData.Desciption + "')";

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






        public static DataSet GetSupplierDetails()
        {
            String sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;

            DataSet dsSuppliers = null;

            try
            {
                sql = "select * from SupplierDetails";
                con = DBHelper.GetConnection();
                con.Open();
                dsSuppliers = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsSuppliers);
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsDSL.cs: GetSupplierDetails()" + e3.Message.ToString());


            }
            finally
            {
                con.Close();

            }
            return dsSuppliers;
        }

    }
}

    

