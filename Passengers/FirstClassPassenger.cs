namespace Passengers;

public class FirstClassPassenger
{
    public int AirMiles { get; init; }

    public override string ToString()
    {
        return $"First Class with {AirMiles:N0} air miles.";
    }
}