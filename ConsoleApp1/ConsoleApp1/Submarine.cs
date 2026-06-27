namespace TransportChallenge;

public class Submarine : Vehicle, ISailable, IDiveable
{
    public override string Move()
    {
        return "Dives underwater.";
    }
}
