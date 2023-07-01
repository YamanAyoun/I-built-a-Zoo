using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.PetAnimal
{
    public class Cat : Pet
    {

        public override string Eat()
        {
            return "Cat is Eating";
        }
        public override string Sound()
        {
            return "Cat Sound: Meow";
        }
        public override string Sleep()
        {
            return "Cat is Sleeping";
        }

        public override void Jump()
        {
            Console.WriteLine("Cat is Jumping");
        }
        public override void Play()
        {
            Console.WriteLine("Cat is Playing");
        }
    }
}
