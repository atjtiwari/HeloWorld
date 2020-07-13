using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeloWorld
{
    class Program
    {
        public void HeloWorld(string name)
        {
            Console.WriteLine("Helo World {0}", name);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.HeloWorld();
            p.welcome("Anupam Tiwari");
            Console.ReadLine();

        }

        public void welcome(string name)
        {
            Console.WriteLine("Welcome {0}", name);
        }
    }
}
