using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifyDTO.DTO
{
    public class UtilityHelper
    {
            public static string GenerateID(string oldId)
            {
                string newId = null;
                string prefix;
                int next;

                try
                {
                    //prefix = oldId.Substring(0, 3);
                    //sufix = oldId.Substring(3);
                    //next = Convert.ToInt32(sufix) + 1;
                    //newId = prefix + next;

                    prefix = oldId.Substring(0, 3);
                    // sufix = oldId.Substring(3);
                    next = Convert.ToInt32(prefix) + 1;
                    newId = Convert.ToString(next);

                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine("****error : UtilityHelper.cs:GenerateID:" + ex.Message.ToString());
                }
                return newId;
            }
    }
}
