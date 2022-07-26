using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ProductCollection
    {
        Product product;
        List<Product> productsList = new List<Product>();




        public ProductCollection() { }
        public ProductCollection(string productName,double price,int quantity) 
        {
/*            product.ProductName = productName;
            product.Price = price;
            product.Quantity = quantity;*/
             product = new Product(productName, price, quantity);
        }

        public Product Search(string productName)
        {
        
                for (int i = 0; i < productsList.Count; i++)
                {
                    if (productName == productsList[i].ProductName)
                        return productsList[i];
                }
            
            return null;
        }
        public void AddProduct(Product product)
        {
            productsList.Add(product);

            Console.WriteLine("Product Added Successfully...");
        }
        public void DisplayAll()
        {
            if (productsList.Count == 0)
                Console.WriteLine("List is Empty.......");
            else
            {
                for (int i = 0; i < productsList.Count; i++)
                {

                    Console.WriteLine(productsList[i].ProductName + " " + productsList[i].Price + " " + productsList[i].Quantity);
                }
            }
        }
        public void DeleteProduct(string productName)
        {
            if (productsList.Count==0)
                Console.WriteLine("List is Empty.......");
            else
            {
                for (int i = 0; i < productsList.Count; i++)
                {
                    if (productName == productsList[i].ProductName)
                    {
                        productsList.Remove(productsList[i]);
                        Console.WriteLine("Product Added Successfully...");

                    }
                }
            }
        }

        List<Product> queryPrice = new List<Product>();
       public List<Product> QueryPrice(int price,char operatorChar) 
        {
            queryPrice.Clear();
                if (operatorChar == '>')
                {
                for (int i = 0; i < productsList.Count; i++)
                {
                    if (productsList[i].Price > price)
                        queryPrice.Add(productsList[i]);
                }

                }
                else if (operatorChar=='<') 
                {
                for (int i = 0; i < productsList.Count; i++)
                {
                    if (productsList[i].Price < price)
                    {
                        queryPrice.Add(productsList[i]);
                    }
                }
                }
                else if (operatorChar == '=')
                {
                for (int i = 0; i < productsList.Count; i++)
                {
                    queryPrice.Add(productsList[i]);
                }

                }
            
            return queryPrice;
        }


    }
    
}
