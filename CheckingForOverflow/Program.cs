using static System.Console;

int x = int.MaxValue - 1;
WriteLine($"Initial value x: {x}");
x++;
WriteLine($"After incrementing x: {x}");
x++;
WriteLine($"After incrementing x: {x}");
x++;
WriteLine($"After incrementing x: {x}");

WriteLine();

unchecked
{
    int y = int.MaxValue - 1;
    WriteLine($"Initial value z: {y}");
    y++;
    WriteLine($"After incrementing z: {y}");
    y++;
    WriteLine($"After incrementing z: {y}");
    y++;
    WriteLine($"After incrementing z: {y}");
}

WriteLine();

checked
{
    int z = int.MaxValue - 1;
    WriteLine($"Initial value y: {z}");
    z++;
    WriteLine($"After incrementing y: {z}");
    z++;
    WriteLine($"After incrementing y: {z}"); // System.OverflowException
    z++;
    WriteLine($"After incrementing y: {z}");
}