namespace TransportChallenge;

public class Submarine : Vehicle, IDiveable
{
    public override string Move()
    {
        return "Dives underwater.";
    }
}
