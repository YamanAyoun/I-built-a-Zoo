using I_built_a_Zoo_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.Classes.Animal.MarineAnimal
{
    public class Fish : Marine, IMove
    {
        public string Type { get; set; }

        public override string Eat()
        {
            return "Fish is Eating";
        }
        public override string Sound()
        {
            return "Fish Sound: fresh";
        }
        public override string Sleep()
        {
            return "Fish is Sleeping";
        }

        public override void Swimming()
        {
            Console.WriteLine("Fish is Swimming");
        }

        public string movementStyle()
        {
            return "Fish is moving using their median and paired fins";
        }
    }
    }
