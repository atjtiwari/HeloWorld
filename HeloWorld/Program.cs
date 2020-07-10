using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeloWorld
{
    class Program
    {
        public void HeloWorld()
        {
            Console.WriteLine("Helo World");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.HeloWorld();
            Console.ReadLine();

        }
    }
}
