using Passengers;

object[] passengers =
{
    new FirstClassPassenger {AirMiles = 1_419},
    new FirstClassPassenger {AirMiles = 16_652},
    new BusinessClassPassenger(),
    new CoachClassPassenger {CarryOnKg = 25.7},
    new CoachClassPassenger {CarryOnKg = 0}
};

foreach (var passenger in passengers)
{
    // decimal flightCost = passenger switch
    // {
    //     FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
    //     FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
    //     FirstClassPassenger _                          => 2_000M,
    //     BusinessClassPassenger _                       => 1_000M,
    //     CoachClassPassenger p when p.CarryOnKG < 10.0  => 500M,
    //     CoachClassPassenger _                          => 650M,
    //     _                                              => 800M
    // };
    // var flightCost = passenger switch
    // {
    //     FirstClassPassenger {AirMiles: > 35_000} => 1_500M,
    //     FirstClassPassenger {AirMiles: > 15_000} => 1_750M,
    //     FirstClassPassenger _ => 2_000M,
    //     BusinessClassPassenger _ => 1_000M,
    //     CoachClassPassenger {CarryOnKg: < 10.0} => 500M,
    //     CoachClassPassenger _ => 650M,
    //     _ => 800M
    // };

    var flightCost = passenger switch
    {
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35_000 => 1_500M,
            > 15_000 => 1_750M,
            _ => 2_000M
        } ,
        BusinessClassPassenger _ => 1_000M,
        CoachClassPassenger p => p.CarryOnKg switch
        {
            < 10.0=> 500M,
            _ => 650M,
        }, 
        _ => 800M
    };
    
    Console.WriteLine($"Flight coast {flightCost:C} for {passenger}");
}