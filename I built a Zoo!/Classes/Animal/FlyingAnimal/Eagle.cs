using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.FlyingAnimal
{
    public class Eagle : Flying
    {
        public override string Eat()
        {
            return "Eagle is Eating Meat";
        }
        public override string Sound()
        {
            return "Eagle Sound: high-pitched whistling";
        }
        public override string Sleep()
        {
            return "Eagle is Sleeping";
        }

        public override void Fly()
        {
            Console.WriteLine("Eagle Can Flying");
        }
    }
}
