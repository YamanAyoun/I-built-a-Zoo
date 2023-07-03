using I_built_a_Zoo_.Classes.Animal.FlyingAnimal;
using I_built_a_Zoo_.Classes.Animal.MammalAnimal;
using I_built_a_Zoo_.Classes.Animal.MarineAnimal;
using I_built_a_Zoo_.Classes.Animal.PetAnimal;

namespace TestZoo
{
    public class UnitTest1
    {
        [Fact]
        public void TestMammalAnimal()
        {
            Mammal lion = new Lion();
            Assert.Equal("Lion Eating Meat", lion.Eat());
        }

        [Fact]
        public void TestPetAnimal()
        {
            Pet cat = new Cat();
            Assert.Equal("Cat Sound: Meow", cat.Sound());
        }

        [Fact]
        public void TestFlyingAnimal()
        {
            Flying chicken = new Chicken();
            Assert.Equal("Chicken is Sleeping", chicken.Sleep());
        }

        [Fact]
        public void TestMarineAnimal()
        {
            Marine fish = new Fish();
            Assert.Equal("Fish is Eating", fish.Eat());
        }

        [Fact]
        public void TestIMove()
        {
            Cat Cat = new Cat();
            Assert.Equal("Cat is move four feet", Cat.movementStyle());
        }

        [Fact]
        public void TestIBreed()
        {
            Cat cat = new Cat();
            Assert.Equal("Cat is Breed", cat.Breed());
        }

    }
}