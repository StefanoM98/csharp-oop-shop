using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Products
    {
        private int serialNumber;
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public decimal vat { get; set; }

        public Products(string productName, decimal productPrice, decimal productVat)
        {
            this.serialNumber = new Random().Next(00000001, 99999999);
            this.name = productName;
            this.price = productPrice;
            this.vat= productVat;
        }
        
        public int SerialNumber
        {
            get { return serialNumber; }
        }
        public string Name 
        { 
            get { return name; } 
        }
        public string Description 
        {
            get { return "no description"; }
        }

        public decimal Price 
        { 
            get { return price; } 
        }
        
        public decimal PriceVat 
        {
            get { return Price + (Price / 100 * vat); }
        }


        
        
    }
}
