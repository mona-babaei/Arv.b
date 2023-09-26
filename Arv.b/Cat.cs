namespace Arv.b;


public class Cat : Animal
{
    public override string Stats => "Detta är en katt.";

    public override string Sound()
{
    return "Mjau!";
}
}

public interface IPerson
{
string Talk();
}