using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Dog : IAnimalEnergy
    {
        int energy = 40;

        public void Eat()
        {
            int a;
            a = energy + 60;
            Console.WriteLine($"Энергия после еды: {a}");
        }
        public void Walk()
        {
            int b;
            b = energy + 50;
            Console.WriteLine($"Энергия после прогулки: {b}");
        }
        public void Info()
        {
            Console.WriteLine($"Энергия собаки: {energy}");
        }
        public void Split()
        {
            Console.WriteLine(" ");
        }
    }
}
