using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.MammalAnimal
{
    public class Lion : Mammal
    {
        public override string Eat()
        {
            return "Lion Eating Meat";
        }
        public override string Sound()
        {
            return "Lion Sound: Roar";
        }
        public override string Sleep()
        {
            return "Lion is Sleeping";
        }

        public override void Danger()
        {
            Console.WriteLine("Lion is Danger!");
        }
    }
}
