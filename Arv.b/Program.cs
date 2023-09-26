
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Arv.b;

public class Program
{
    public static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog(),
            new Cat()
        };

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Stats);
            Console.WriteLine(animal.Sound());

            if (animal is IPerson person)
            {
                Console.WriteLine(person.Talk());
            }
        }

        List<Dog> dogs = new List<Dog>
        {
            new Dog()
        };

        foreach (var dog in dogs)
        {
            Console.WriteLine(dog.NewMethod());
        }

        foreach (var animal in animals)
        {
            if (animal is Dog dog)
            {
                Console.WriteLine(dog.NewMethod());
                Console.ReadLine();
            }
        }
       
        animals.Add(new Horse());

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Stats);
            Console.ReadLine();
        }
    }
}


//om vi skapar en horse klass som  en subklass till animal:
//public class Horse : Animal
//{
// public override string Stats()
//{
// return "Detta är en häst.";}

// och försöker lägga till en horse i en lista av dog
//List<Dog> dogs = new List<Dog>();
//dogs.Add(new Horse());  // Fel här
//detta fungerar inte eftersom horse inte är en subklass till dog


