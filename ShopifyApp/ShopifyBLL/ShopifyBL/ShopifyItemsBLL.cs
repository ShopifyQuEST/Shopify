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
                Console.Out.WriteLine(" inside catch-ERROR : stdent_mark_Bl.cs:StudentMarkupdate" + e3.Message.ToString());


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
                Console.Out.WriteLine(" inside catch-ERROR : student_.cs " + e3.Message.ToString());


            }

            return shopifyItems;
        }

        public static DataSet GetContactIDs()
        {
            //String sql = "";

            DataSet dsSTudents = null;

            try
            {

                dsSTudents = ShopifyItemsDSL.GetContactIDs();


            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : student_BL.cs " + e3.Message.ToString());


            }

            return dsSTudents;
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
                Console.Out.WriteLine(" inside catch-ERROR : student_DAO.cs " + e3.Message.ToString());


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
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyBLL.cs :GetDetails()" + e3.Message.ToString());


            }

            return dsSTudents;
        }

    }
}
