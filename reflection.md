Why did you use inheritance?
To create a parent-child relationship between the Vehicle base class and the specific transport classes

Why did you use interfaces?
To define specific capabilities or behaviors that a vehicle can have, so the system can verify what an object is capable of doing

Can Helicopter inherit from both Vehicle and Airplane? Why or why not?
No, because you can only inherit once.

Why can Helicopter implement both IFlyable and IDriveable?
Because C# explicitly allows a class to implement multiple interfaces.

If a Submarine can both sail and dive, how would you design it?

namespace TransportChallenge;
public class Submarine : Vehicle, ISailable, IDiveable
{
public override string Move()
{
return "Dives underwater.";
}
}
