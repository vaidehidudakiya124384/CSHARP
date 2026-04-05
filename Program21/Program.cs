using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars c = new Cars();
            c.get_data();
            c.get_car();
            c.show_car();
            c.show_vehicle();
        }
    }
}
