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
        private string name;
        public string description = "purtroppo non abbiamo una descrizione del prodotto";
        public decimal price;
        public decimal vat;

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
            get { return description; }
        }

        public decimal Price 
        { 
            get { return price; } 
        }
        
        public decimal PriceVat 
        {
            get { return Price + (Price / 100 * vat); }
        }

        //Metodi

        public string GetFullName()
        {
            string fullname = $"{this.name} code: {this.serialNumber}";
            return fullname;
        }

        
        
    }
}
