using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTryCatchCommand
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nPERSON");
            Console.Write("PERSON NAME: ");
            string personName = Console.ReadLine();

            Console.Write("HEIGHT: ");
            double personHeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("WEIGHT: ");
            double personWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("PERSON YEARS: ");
            int personYearsLife = Convert.ToInt32(Console.ReadLine());

            Console.Write("PERSON SECURITY CODE: ");
            string personSecurityCode = Console.ReadLine();

            Person personOne = new Person(personName, personHeight, personWeight, personYearsLife, personSecurityCode);

            Console.WriteLine("\nPRODUCT");
            Console.Write("PRODUCT NAME: ");
            string productName = Console.ReadLine();

            Console.Write("PRODUCT COLOR: ");
            string productColor = Console.ReadLine();

            Console.Write("PRODUCT PRICE: ");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            Console.Write("PRODUCT WEIGHT: ");
            double productWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("PRODUCT HEIGHT: ");
            double productHeight = Convert.ToDouble(Console.ReadLine());


            Product productOne = new Product();
            
            productOne.Name = productName;
            productOne.Color = productColor;
            productOne.Price = productPrice;
            productOne.Weight = productWeight;
            productOne.Height = productHeight;

            personOne.AddProductAtList(productOne);

            personOne.ShowAllPersonInformationAndAllPersonProductList(personOne);
          
        }
    }
}
