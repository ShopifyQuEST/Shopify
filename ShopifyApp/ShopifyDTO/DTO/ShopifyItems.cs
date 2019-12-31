using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifyDTO.DTO
{
   public  class ShopifyItems
    {
        private string productid;
        public String Productid
        {
            get { return productid; }
            set
            {
                productid = value;
            }
        }
        private string productname;
        public String Productname
        {
            get { return productname; }
            set
            {
                productname = value;
            }
        }
        private double unitprice;
        public double Unitprice
        {
            get { return unitprice; }
            set
            {
                unitprice = value;
            }
        }
        private double quantity;
        public double Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }
        private string supplierid;
        public String Supplierid
        {
            get { return supplierid; }
            set
            {
                supplierid = value;
            }
        }
        private string date;
        public String Date
        {
            get { return date; }
            set
            {
                date = value;
            }
        }




    }

    public class SupplierData
    {

        private string supplierId;
        public String SupplierId
        {
            get { return supplierId; }
            set
            {
                supplierId = value;
            }
        }
        private string supplierName;
        public String SupplierName
        {
            get { return supplierName; }
            set
            {
                supplierName = value;
            }
        }
        private double contactNumber;
        public Double ContactNumber
        {
            get { return contactNumber; }
            set
            {
                contactNumber = value;
            }
        }
        private string desciption;
        public String Desciption
        {
            get { return desciption; }
            set
            {
                desciption = value;
            }
        }


    }

}
