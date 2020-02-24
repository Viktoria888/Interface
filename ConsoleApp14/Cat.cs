using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Cat : IAnimalEnergy
    {
        int energy = 30;

        public void Eat()
        {
            int a;
            a = energy + 50;
            Console.WriteLine($"Энергия после еды: {a}");
        }
        public void Walk()
        {
            int b;
            b = energy + 30;
            Console.WriteLine($"Энергия после прогулки: {b}");
        }
        public void Info()
        {
            Console.WriteLine($"Энергия кота: {energy}");
        }
        public void Split()
        {
            Console.WriteLine(" ");
        }
    }
}
