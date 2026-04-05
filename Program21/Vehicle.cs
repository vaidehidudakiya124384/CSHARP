using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program21
{
    internal class Vehicle
    {
        string vehicle_type;

        public void get_data()
        {
            Console.WriteLine("Enter Vehicle Type:");
            vehicle_type = Console.ReadLine();
        }

        public void show_vehicle()
        {
            Console.WriteLine("Vehicle type" + vehicle_type);
        }
    }
}
