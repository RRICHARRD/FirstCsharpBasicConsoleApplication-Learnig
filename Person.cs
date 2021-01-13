using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTryCatchCommand
{
    public class Person
    {
        public string name;
        public string height;
        public string securityCode;
        public List<Product> personProductList = new List<Product>();

        public Person(string name, string height, string securityCode)
        {
            this.name = name;
            this.height = height;
            this.securityCode = securityCode;
        }

        public static void checkIfIsAInstance(Object person)
        {
            try
            {
                if (person is Person)
                    Console.WriteLine("IT'S A INSTANCE");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("THIS ISN'T A PERSON INSTANCE");
            }
        }

        public void writeInformations(Person person)
        {
            Console.WriteLine("NAME: {0}" +
                              "\nHEIGHT: {1}" +
                              "\nSECURITY CODE: {2}", person.name, person.height, person.securityCode);
        }

        public void showProductList()
        {
            foreach (Product product in personProductList)
            {
                Console.WriteLine(Product.toString(product));
            }
        }
    }
}
