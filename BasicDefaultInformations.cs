using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTryCatchCommand
{
    public abstract class BasicDefaultInformations
    {
        private string name;
        private double height;
        private double weight;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Height
        {
            get => height;
            set => height = value;
        }

        public double Weight
        {
            get => weight;
            set => weight = value;
        }
    }
}
