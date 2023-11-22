using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        public string Brand { get; set; }

        public Laptop(string brand)
        {
            Brand = brand;
        }

        public bool connect()
        {
         
            Console.WriteLine($"{Brand} laptop connected successfully.");
            return true;
        }

        public void charge(int minutes)
        {
           
            Console.WriteLine($"{Brand} laptop is charging for {minutes} minutes.");
        }

        public string Display()
        {
            
            return $"{Brand} display: welcome";
        }

    }
}
