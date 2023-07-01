using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.FlyingAnimal
{
    public abstract class Flying : Animal
    {
        public string Color { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine("Animal is Flying");
        }
    }
}
