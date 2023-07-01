using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal
{
    public abstract class Animal
    {
        private string name { get; set; }
        private int age { get; set; }


        public abstract string Eat();
        public abstract string Sound();
        public abstract string Sleep();
    }
}
