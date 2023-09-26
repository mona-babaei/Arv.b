namespace Arv.b;

    public class Dog : Animal, IPerson
{
    public override string Stats => "Detta är en hund.";

    public override string Sound()
    {
        return "Vov!";
    }

    public string Talk()
    {
        return "Jag är en hund som pratar!";
    }

    public string NewMethod()
    {
        return "Valfri sträng.";
    }
}
