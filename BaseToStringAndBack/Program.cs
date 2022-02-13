byte[] binaryObject = new byte[128];

new Random().NextBytes(binaryObject);

Console.WriteLine("Binary object as bytes:");

for(var index = 0; index < binaryObject.Length; index++)
{
    Console.Write($"{binaryObject[index]:X} ");
}

// foreach (var t in binaryObject)
// {
//     Console.Write($"{t:X}");
// }

Console.WriteLine();

string encoded = Convert.ToBase64String(binaryObject);
Console.WriteLine($"Binary object as string: {encoded}");