using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle car1 = new Vehicle();
            Corsa car2 = new Corsa();
            Console.WriteLine(car2.wheels);

            Console.ReadLine();
        }
    }
}
