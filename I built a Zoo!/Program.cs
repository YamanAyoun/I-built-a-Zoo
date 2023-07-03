using I_built_a_Zoo_.Classes.Animal.FlyingAnimal;
using I_built_a_Zoo_.Classes.Animal.MammalAnimal;
using I_built_a_Zoo_.Classes.Animal.MarineAnimal;
using I_built_a_Zoo_.Classes.Animal.PetAnimal;

namespace I_built_a_Zoo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome my Zoo");
            Flying chicken = new Chicken();
            chicken.Fly();
            Console.WriteLine(chicken.Sleep());
            chicken.Color = "Broun";
            Console.WriteLine($"Chicken Color is {chicken.Color}");
           
            Mammal Lion=new Lion();
            Console.WriteLine(Lion.Eat());
            Lion.Danger();

            Fish fish = new Fish();
            fish.movementStyle();

            Cat cat = new Cat();
            cat.movementStyle();
            cat.Breed();
            
        }
    }
}