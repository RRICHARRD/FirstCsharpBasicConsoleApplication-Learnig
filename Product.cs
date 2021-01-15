using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTryCatchCommand
{
    public sealed class Product : BasicDefaultInformations
    {
        private string color;
        private decimal price;

        public string Color
        {
            get => color;
            set => color = value;
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }
      
        public string ToString(Product product)
        {
            return string.Format("\nPRODUCT" +
                                $"\nNAME: {product.Name}" +
                                $"\nCOLOR: {product.Color}" +
                                $"\nPRICE: {product.Price:c}" +
                                $"\nHEIGHT: {product.Height}" +
                                $"\nWEIGHT: {product.Weight}");
        }

    }
}
