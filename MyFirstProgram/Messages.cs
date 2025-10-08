using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    static class Messages // Static class to hold message methods. Solutions explorer, right click add new item, class, name it Messages.cs
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Welcome");
        }
        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something");
        }
        public static void Bye()
        {
            Console.WriteLine("Bye!");
        }
    }
}
