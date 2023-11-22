using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class SmartPhone: IConnectable, IRechargeable, IDisplayable
    {
        public string Model { get; set; }

        public SmartPhone(string model)
        {
            Model = model;
        }

        public bool connect()
        {
           
            Console.WriteLine($"{Model} connected successfully.");
            return true;
        }

        public void charge(int minutes)
        {
           
            Console.WriteLine($"{Model} is charging for {minutes} minutes.");
        }

        public string Display( )
        {
           
            return $"{Model} display: welcome";
        }


    }
}
