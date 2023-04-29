using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsList.Logic
{
    public class Cars
    {
        public string Brand 
        { get; 
          set; 
        }
        public string Model 
        { 
            get; 
            set; 
        }
        public string Color 
        { 
            get; 
            set; 
        }
        public int Year
        {
            get;
            set;
        }
        public decimal Price 
        { 
            get; 
            set; 
        }

        public Cars(string brand, int year, string model, decimal price, string color)
        {
            Brand= brand;
            Year=  year;
            Model= model;
            Price= price;
            Color= color;
        }

        public override string ToString()
        {
            return $"*{Brand}/{Year}/{Model}/{Price:C2}/{Color}";
        }

    }
}

