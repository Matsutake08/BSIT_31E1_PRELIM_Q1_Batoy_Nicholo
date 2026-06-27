namespace TransportChallenge;

public static class TransportResolver
{
    public static Vehicle? Resolve(string transportType)
    {
        switch (transportType.ToLower())
        {
            case "car":
                return new Car();
            case "plane":
                return new Airplane();
            case "boat":
                return new Boat();
            case "helicopter":
                return new Helicopter();
            case "motorcycle":
                return new Motorcycle();
            case "submarine":
                return new Submarine();
            case "drone":
                return new Drone();
            default:
                return null;
        }
    }
}