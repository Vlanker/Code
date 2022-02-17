namespace Passengers;

public class CoachClassPassenger
{
    public double CarryOnKg { get; init; }

    public override string ToString()
    {
        return $"Coach Class with {CarryOnKg:N2} Kg carry on.";
    }
}