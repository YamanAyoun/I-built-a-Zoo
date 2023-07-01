using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.PetAnimal
{
    public abstract class Pet : Animal
    {
        string Color { get; set; }

        public virtual void Jump()
        {
            Console.WriteLine("Pet is Jump");
        }
        public virtual void Play()
        {
            Console.WriteLine("Pet is Play");
        }
    }
}
