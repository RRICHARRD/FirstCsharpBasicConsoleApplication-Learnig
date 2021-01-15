using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTryCatchCommand
{
    public class Person
    {
        private string name;
        private string height;
        private string securityCode;
        public List<Product> personProductList = new List<Product>();

        public Person(string name, string height, string securityCode)
        {
            this.name = name;
            this.height = height;
            this.securityCode = securityCode;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public string Height
        {
            get => height;
            set => height = value;
        }

        public string SecurityCode
        {
            get => securityCode;
            set => securityCode = value;
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

        public static void ShowPersonInformation(Person person)
        {
            Console.WriteLine("NAME: {0}" +
                              "\nHEIGHT: {1}" +
                              "\nSECURITY CODE: {2}", person.name, person.height, person.securityCode);
        }

        public void showEachProductInProductList()
        {
            foreach (Product product in personProductList)
            {
                Console.WriteLine(Product.toString(product));
            }
        }
    }
}
