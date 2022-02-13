using static System.Console;

int x = int.MaxValue - 1;
WriteLine($"Initial value: {x}");
x++;
WriteLine($"After incrementing: {x}");
x++;
WriteLine($"After incrementing: {x}");
x++;
WriteLine($"After incrementing: {x}");

WriteLine();

checked
{
    int y = int.MaxValue - 1;
    WriteLine($"Initial value: {y}");
    y++;
    WriteLine($"After incrementing: {y}");
    y++;
    WriteLine($"After incrementing: {y}"); // System.OverflowException
    y++;
    WriteLine($"After incrementing: {y}");
}