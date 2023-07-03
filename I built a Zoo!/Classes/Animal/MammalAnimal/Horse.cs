using I_built_a_Zoo_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.MammalAnimal
{
    public class Horse : Mammal, IMove
    {
        public override string Eat()
        {
            return "Horse Eating grass";
        }
        public override string Sound()
        {
            return "Horse Sound: neigh";
        }
        public override string Sleep()
        {
            return "Horse is Sleeping standing up ";
        }

        public override void Danger()
        {
            Console.WriteLine("Horse is not Danger");
        }

        public string movementStyle()
        {
            return "Horse is move four feet";
        }
    }
}
