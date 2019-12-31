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

        public static int StockInsert(ShopifyItems shopifyItems)
        {
            int output = 0;

            try
            {
                output = ShopifyItemsDSL.StockInsert(shopifyItems);
            }

            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs " + e3.Message.ToString());
            }


            return output;



        }


        //-----------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------

        public static DataSet GetSalesBL(string ShowIdBill)
        {
            DataSet sales = null;

            try
            {
                sales = ShopifyItemsDSL.GetSalesDL(ShowIdBill);

            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : ShopifyItemsBLL.cs:GetSalesBL:" + exe.Message.ToString());
            }

            return sales;
        }



        public static int SaleEachInsertBL(ShopifyItems shopifyItems)
        {
            int output = 0;

            try
            {

                shopifyItems.TotalSale = shopifyItems.Quantity * shopifyItems.Unitprice;
                

                output = ShopifyItemsDSL.SaleEachInsertDL(shopifyItems);
                shopifyItems.Total = ShopifyItemsDSL.GetTotalSaleDL(shopifyItems.Salesid);
            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : ShopifyItemsBLL.cs:SaleEachInsertBL:" + exe.Message.ToString());
            }
            return output;

        }


        public static int SalesInsertBL(ShopifyItems shopifyItems)
        {
            int output = 0;

            try
            {

                shopifyItems.Total = ShopifyItemsDSL.GetTotalSaleDL(shopifyItems.Salesid);

                output = ShopifyItemsDSL.SalesInsertDL(shopifyItems);
            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : ShopifyItemsBLL.cs:SalesInsertBL:" + exe.Message.ToString());
            }
            return output;

        }




        public static String GetLastSalesId()
        {
            string LastStudentId = null;
            string newStudentId = null;

            try
            {
                LastStudentId = ShopifyItemsDSL.GetLastSalesIdDL();
                if (LastStudentId != null)
                {
                    newStudentId = UtilityHelper.GenerateID(LastStudentId);
                }
                else
                {
                    newStudentId = "101";
                }
            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : ShopifyItemsBLL.cs:GetLastSalesIdBL:" + exe.Message.ToString());
            }

            return newStudentId;
        }



    }
}
