using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace TestProduct
{
    internal class Program
    {


        static void Main(string[] args)
        {
           //  Product product = new Product("sdsd", 50.25, 78);
            //ProductCollection productCollection1 = new ProductCollection();

            ProductCollection productCollection= new ProductCollection();
            char yesOrNO ;
            while (true)
            {

                Console.WriteLine("\n1.Add Product \n2.Delete Product \n3.Display\n4.Search\n5.Query Price\n6.Quit\n");
                Console.WriteLine("\nEnter Your Choice");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (choice == 1)
                    {
                        Console.WriteLine("Enter the Product Name: ");
                        string productName = Console.ReadLine();
                        Console.WriteLine("Enter the Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Qunatity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        Product product = new Product { ProductName = productName, Price = price, Quantity = quantity };
                        productCollection.AddProduct(product);
                    }
                    else if (choice == 3)
                    {
                        productCollection.DisplayAll();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Enter the Product Name: ");
                        string pName = Console.ReadLine();
                        productCollection.DeleteProduct(pName);
                    }
                    else if (choice == 4)
                    {

                        Console.WriteLine("Enter the Product Name");
                        string findProduct = Console.ReadLine();
                        try
                        {
                            Product searchedProduct = productCollection.Search(findProduct);
                            if (findProduct != null)
                                Console.WriteLine("Searched=> Product Name: " + searchedProduct.ProductName + " Price:  " + searchedProduct.Price + " Quantity:  " + searchedProduct.Quantity);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("List is Empty...");
                        }
                    }
                    else if (choice == 5)
                    {
                        char operatorChar='a';
                        Console.WriteLine("Enter the price...");
                        int price=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Operator Number: 1.Greater than(>)\n2.Less than(<)\n3.Equal(=)");
                        int operatorNo = Convert.ToInt32(Console.ReadLine());
                        if (operatorNo == 1)
                            operatorChar = '>';
                        else if (operatorNo == 2)
                            operatorChar = '<';
                        else if (operatorNo == 3)
                            operatorChar = '=';


                     List<Product> qp=productCollection.QueryPrice(price,operatorChar);
                        for (int i = 0; i < qp.Count; i++) 
                        {
                            Console.WriteLine(qp[i].ProductName+" "+qp[i].Price+" "+qp[i].Quantity);
                        }

                    }
                    else if (choice == 6)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter the Correct Option Number!!!!!\n");
                    }
                    Console.WriteLine("\nDo you want to continue Y/N");
                    yesOrNO = Convert.ToChar(Console.ReadLine());
                    yesOrNO = char.ToUpper(yesOrNO);
                    if (yesOrNO == 'N')
                        break;
                    else if (yesOrNO != 'Y')
                        break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter the Correct Option,Try Again");
                }
            }
            



        }
       

    }
}
