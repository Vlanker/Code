using static System.Console;

RunCardinalToOriginal();

static string CardinalToOriginal(int number)
{
    switch (number)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;

            string suffinx = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };

            return $"{number}{suffinx}";
    }
}

static void RunCardinalToOriginal()
{
    for (int number = 1; number <= 40; number++)
    {
        Write($"{CardinalToOriginal(number)} ");
    }

    WriteLine();
}