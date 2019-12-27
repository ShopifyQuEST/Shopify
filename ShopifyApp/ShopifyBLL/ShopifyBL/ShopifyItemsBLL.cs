using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifyDTO.DTO;
using System.Data.SqlClient;
using ShopifyDSL.DL;


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

    }
}
