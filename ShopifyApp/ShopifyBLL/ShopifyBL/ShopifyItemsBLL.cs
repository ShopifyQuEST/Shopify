using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifyDTO.DTO;
using System.Data.SqlClient;
using ShopifyDSL.DL;
using System.Data;

namespace ShopifyBLL.ShopifyBL
{
   public class ShopifyItemsBLL
    {



        //Method for stock insert in BLL

        public static int StockInsert(ShopifyItems shopifyItems)
        {
            int output = 0;

            try
            {
                output = ShopifyItemsDSL.StockInsert(shopifyItems);
            }

            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs :StockInsert()" + e3.Message.ToString());
            }
            return output;
        }





        public static int StockUpdate(ShopifyItems shopifyItems)
        {
            int output = 0;


            try
            {


                output = ShopifyItemsDSL.StockUpdate(shopifyItems);
                ////////////


            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs:StockUpdate" + e3.Message.ToString());


            }

            return output;
        }


        //update supplier


        public static int SupplierUpdate(SupplierData supplierData)
        {
            int output = 0;


            try
            {


                output = ShopifyItemsDSL.SupplierUpdate(supplierData);
                ////////////


            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs:SupplierUpdate()" + e3.Message.ToString());


            }

            return output;
        }



        public static ShopifyItems GetByID(string productid)
        {

            ShopifyItems shopifyItems = null;

            try
            {

                shopifyItems = ShopifyItemsDSL.GetByID(productid);

            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs: GetByID()" + e3.Message.ToString());


            }

            return shopifyItems;
        }


        //BLL search 

        public static SupplierData GetBySupplierID(string supplierid)
        {

            SupplierData supplierData = null;

            try
            {

                supplierData = ShopifyItemsDSL.GetBySupplierID(supplierid);

            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs :GetBySupplierID()" + e3.Message.ToString());


            }

            return supplierData;
        }



        public static DataSet GetProductID()
        {
            //String sql = "";

            DataSet dsStockID = null;

            try
            {

                dsStockID = ShopifyItemsDSL.GetProductID();


            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs :GetContactIDs" + e3.Message.ToString());


            }

            return dsStockID;
        }

        //Get supplier id in combo box

        public static DataSet GetSupplierIDs()
        {
            //String sql = "";

            DataSet dsSuppliers = null;

            try
            {

                dsSuppliers = ShopifyItemsDSL.GetSupplierIDs();


            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs :GetSupplierIDs()" + e3.Message.ToString());


            }

            return dsSuppliers;
        }







        public static int DeleteItem(string id)
        {
            int output = 0;

            try
            {
                output = ShopifyItemsDSL.DeleteItem(id);

               

            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs :DeleteItem()" + e3.Message.ToString());


            }

            return output;
        }



        public static int DeletingItem(string id)
        {
            int output = 0;

            try
            {
                output = ShopifyItemsDSL.DeletingItem(id);



            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs: DeletingItem()" + e3.Message.ToString());


            }

            return output;
        }





        public static DataSet GetDetails()
        {
            //String sql = "";

            DataSet dsSTudents = null;

            try
            {

                dsSTudents = ShopifyItemsDSL.GetDetails();


            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs :GetDetails()" + e3.Message.ToString());


            }

            return dsSTudents;
        }







        public static int SupplierAdd(SupplierData supplierData)
        {
            int output = 0;

            try
            {
                output = ShopifyItemsDSL.SupplierAdd(supplierData);
            }

            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs:SupplierAdd() " + e3.Message.ToString());
            }


            return output;


        }


        public static DataSet GetSupplierDetails()
        {
            //String sql = "";

            DataSet dsSuppliers = null;

            try
            {

                dsSuppliers = ShopifyItemsDSL.GetSupplierDetails();


            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs :GetSupplierDetails()" + e3.Message.ToString());


            }

            return dsSuppliers;
        }




    }
}
