RunFibImperative();

static int FibImperative(int term)
{
    // if (term == 1)
    // {
    //     return 0;
    // }
    // else if (term == 2)
    // {
    //     return 1;
    // }
    // else
    // {
    //     return FibImperative(term - 1) + FibImperative(term - 2);
    // }
    //
    return term switch
    {
        1 => 0,
        2 => 1,
        _ => FibImperative(term - 1) + FibImperative(term - 2)
    };
}

static void RunFibImperative()
{
    for (int term = 1; term <= 30; term++)
    {
        Console.WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
            arg0:);
    }
}