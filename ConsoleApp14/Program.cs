using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Giraffe giraffe = new Giraffe();
            giraffe.Info();
            giraffe.Eat();
            giraffe.Walk();
            giraffe.Split();

            Cat cat = new Cat();
            cat.Info();
            cat.Eat();
            cat.Walk();
            cat.Split();

            Dog dog = new Dog();
            dog.Info();
            dog.Eat();
            dog.Walk();
            dog.Split();


            Console.ReadLine();
        }
    }
}
