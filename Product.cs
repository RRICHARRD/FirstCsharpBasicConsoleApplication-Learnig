using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTryCatchCommand
{
    public class Product
    {
        string name;
        string color;
        decimal price;

        public Product(string name, string color, decimal price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public void showInformations(Product product)
        {
            Console.WriteLine("NAME: {0}" +
                              "\nCOLOR: {1}" +
                              "\nPRICE: {2:c}", product.name, product.color, product.price);            
        }

        public static string toString(Product product)
        {
           return string.Format("PRODUCT" +
                                "\nNAME: {0}" +
                                "\nCOLOR: {1}" +
                                "\nPRICE: {2:c}", 
                                product.name, product.color, product.price);
        }
    }
}
