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
            
            Console.Write("PERSON NAME: ");
            string personName = Console.ReadLine();

            Console.Write("PERSON YEARS: ");
            string personYears = Console.ReadLine();

            Console.Write("PERSON SECURITY CODE: ");
            string personSecurityCode = Console.ReadLine();

            Person personOne = new Person(personName, personYears, personSecurityCode);
            
            Person.checkIfIsAInstance(personOne);
            personOne.writeInformations(personOne);
            
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");

            Console.Write("PRODUCT NAME: ");
            string productName = Console.ReadLine();

            Console.Write("PRODUCT COLOR: ");
            string productColor = Console.ReadLine();

            Console.Write("PRODUCT PRICE: ");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());
            
            Product productOne = new Product(productName, productColor, productPrice);

            Person.checkIfIsAInstance(productOne);
            productOne.showInformations(productOne);

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");

            personOne.personProductList.Add(productOne);
            Console.WriteLine("----------------*******************************-----------------");
            personOne.showProductList();
        }
    }
}
