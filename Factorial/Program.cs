RunFactorial();

static int Factorial(int number)
{
    // if (number < 1)
    // {
    //     return 0;
    // }
    //
    // if (number == 1)
    // {
    //     return 1;
    // }
    //
    // return number * Factorial(number - 1);
    
    return number switch
    {
        < 1 => 0,
        1 => 1,
        _ => number * Factorial(number - 1)
    };
}

static void RunFactorial()
{
    for (int i = 1; i < 15; i++)
    {
        Console.WriteLine($"{i}! =  {Factorial(i):N0}");
    }
}