using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static int Main(string[] args)
        {
            Menu menu = new Menu();
            while (menu.menu()) {}
            return 0;
        }
    }
}
