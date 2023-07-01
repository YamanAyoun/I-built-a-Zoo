using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.MarineAnimal
{
    public abstract class Marine : Animal
    {
        public string Size { get; set; }

        public virtual void Swimming()
        {
            Console.WriteLine("Animal is Swimming");
        }
    }

}
