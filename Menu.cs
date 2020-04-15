using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Menu
    {
        public bool menu()
        {
            Console.WriteLine("Введите действие: *, /, +, -");
            string input = Console.ReadLine();
            switch (input)
            {
                case "*":
                    break;
                case "/":
                    break;
                case "+":
                    break;
                case "-":
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
