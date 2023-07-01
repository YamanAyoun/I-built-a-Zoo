using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.MammalAnimal
{
    public abstract class Mammal : Animal
    {
        public string Gender { get; set; }
        public int Speed { get; set; }

        public virtual void Danger()
        {
            Console.WriteLine("This Mammal is Danger");
        }
    }
}
