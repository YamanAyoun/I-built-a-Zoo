using I_built_a_Zoo_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.PetAnimal
{
    public class Cat : Pet, IMove, IBreed
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

        public string Breed()
        {
            return "Cat is Breed";
        }

        public string movementStyle()
        {
            return "Cat is move four feet";
        }
    }
}
