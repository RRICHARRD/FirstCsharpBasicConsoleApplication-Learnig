using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTryCatchCommand
{
    public sealed class Person : BasicDefaultInformations
    {
        private int yearsLife;
        private string securityCode;
        private List<Product> productList = new List<Product>();

        public Person(string name, double height, double weight, int yearsLife, string securityCode)
        {
            base.Name = name; 
            base.Height = height;
            base.Weight = weight;

            this.yearsLife = yearsLife;
            this.securityCode = securityCode;
        }

        public int YearsLife
        {
            get => yearsLife;
            set => yearsLife = value;
        }

        public string SecurityCode
        {
            get => securityCode;
            set => securityCode = value;
        }

        public void AddProductAtList(Product product)
        {
            this.productList.Add(product);
        }

        public static void CheckIfIsAInstance(Object person)
        {
            try
            {
                if (person is Person)
                    Console.WriteLine("IT'S INSTANCE OF PERSON");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("THIS OBJECT ISN'T INSTANCE OF PERSON");
            }
        }

        public void ShowAllPersonInformationAndAllPersonProductList(Person person)
        {
            ShowEachPersonInformation(person);
            ShowEachProductInPersonProductList();
        }

        public void ShowEachPersonInformation(Person person)
        {
            Console.WriteLine($"\nNAME: {person.Name}" +
                              $"\nYEARS: {person.YearsLife}" +
                              $"\nHEIGHT: {person.Height}" +
                              $"\nWEIGHT: {person.Weight}" +
                              $"\nSECURITY CODE: {person.SecurityCode}");
        }

        public void ShowEachProductInPersonProductList()
        {
            foreach (Product product in productList)
            {
                Console.WriteLine(product.ToString(product));
            }
        }
        
    }
}
