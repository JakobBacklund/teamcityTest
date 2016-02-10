using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Talang2015
{
    [TestFixture]
    public class TestClasses
    {
        

        [Test]
        public void should_be_able_to_create_an_instance_of_dog()
        {
            var lassie = new Dog(Gender.Female);
            Assert.That(lassie, Is.InstanceOf<Dog>());
        }

        [Test]
        public void lassie_is_yellow()
        {
            var lassie = new Dog(Gender.Female);
            lassie.Color = "yellow";
            Assert.That(lassie.Color, Is.EqualTo("yellow"));
        }

        [Test]
        public void lassie_talks()
        {
            var lassie = new Dog(Gender.Female);
            var hello = lassie.Says("hello");
            var feedMe = lassie.Says("feed me");

            Assert.That(hello, Is.EqualTo("BARF!"));
            Assert.That(feedMe, Is.EqualTo("WOOF!"));
        }

        [Test]
        public void dog_is_an_animal()
        {
            var lassie = new Dog(Gender.Female);
            Assert.That(lassie, Is.InstanceOf<Animal>());
        }

        [Test]
        public void dog_and_cat_has_different_IQ()
        {
            var cheeta = new Cat(Gender.Female);
            var lassie = new Dog(Gender.Female);
            cheeta.IQ = 100;
            lassie.IQ = 7;

            Assert.That(cheeta.IQ, Is.GreaterThan(lassie.IQ));
        }

        [Test]
        public void kennel_has_1_dog_and_2_cats()
        {
            var donna = new Cat(Gender.Female);
            var cheeta = new Cat(Gender.Female);
            var lassie = new Dog(Gender.Female);

            Kennel.HousesPet(donna);
            Kennel.HousesPet(cheeta);
            Kennel.HousesPet(lassie);

            Assert.That(Kennel.NoOfDogs, Is.EqualTo(1));
            Assert.That(Kennel.NoOfCats, Is.EqualTo(2));
        }

        [Test]
        public void cheeta_is_female()
        {
            var cheeta = new Cat(Gender.Female);
            Assert.That(cheeta.Gender, Is.EqualTo(Gender.Female));
        }

        [Test]
        public void lassie_is_male()
        {
            var lassie = new Dog(Gender.Male);
            Assert.That(lassie.Gender, Is.EqualTo(Gender.Male));
        }

        [Test]
        public void lassie_is_fetching_shoes()
        {
            var lassie = new Dog(Gender.Male);
            Assert.That(lassie.GetLoafers(), Is.EqualTo("Happy to oblige master!"));
        }

        [Test]
        public void cheeta_is_not_fetching_shoes()
        {
            var cheeta = new Cat(Gender.Female);
            var exception = Assert.Throws<CatException>(() => cheeta.GetLoafers());
            Assert.That(exception.Message, Is.EqualTo("not gonna happen"));
        }

        


}

    public enum Gender { Male, Female }

    public class Animal
    {
        public Gender Gender { get; set; }
        
        public int IQ { get; set; }

        public String GetLoafers()
        {
            if (this.GetType() == typeof (Cat))
                throw new CatException("not gonna happen", "original");
            return "Happy to oblige master!";
        }
    }

    public class Kennel
    {
        static int nrOfCats = 0;
        static int nrOfDogs = 0;
        public static void HousesPet(Animal pet)
        {
            if (pet.GetType() == typeof (Dog))
                nrOfDogs++;
            if (pet.GetType() == typeof(Cat))
                nrOfCats++;
        }

        public static int NoOfDogs()
        {
            return nrOfDogs;
        }

        public static int NoOfCats()
        {
            return nrOfCats;
        }
    }

    public class Dog : Animal
    {
        public String Color { get; set; }

        public String Says(string word)
        {
            if (word == "hello")
                return "BARF!";
            if (word == "feed me")
                return "WOOF!";
            return null;
        }
        public Dog(Gender gender)
        {
            this.Gender = gender;
        }
    }

    public class Cat : Animal
    {
        public Cat(Gender gender)
        {
            this.Gender = gender;
        }
    }

    public class CatException : Exception
    {
        public CatException(string message, string extrainfo) : base(message)
        {
        }
    }
    


}
