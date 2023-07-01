using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.FlyingAnimal
{
    public class Chicken : Flying
    {
        public override string Eat()
        {
            return "Chicken is Eating grass";
        }
        public override string Sound()
        {
            return "Chicken Sound: cluckk";
        }
        public override string Sleep()
        {
            return "Chicken is Sleeping";
        }

        public override void Fly()
        {
            Console.WriteLine("Chicken Can't Flying");
        }
    }
}
