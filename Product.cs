using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Product
    {
        string productName;
        double price;
        int quantity;

        double total;
        public double Total
        {
            get
            {
                return quantity*price;
            }
            
        }
        public string ProductName{ get;set;}
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product() { }
        public Product(string productName,double price,int quantity)
        { 
            this.productName = productName;   
            this.price = price; 
            this.quantity = quantity;  
            
        }



    }
}
