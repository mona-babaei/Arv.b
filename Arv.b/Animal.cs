namespace Arv.b;

public class Animal
{
    public virtual string Stats => "Detta är ett djur.";

    public virtual string Sound()
    {
        return "Djurets ljud.";
    }
}
//listan måste vara av typen Animal för att kunna lagra alla subklasser
//av Animal
//List<Animal> animals = new List<Animal>();
//animals.Add(new Dog());
//animals.Add(new Horse());
