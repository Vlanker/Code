byte[] binaryObjects = new byte[128];

new Random().NextBytes(binaryObjects);

Console.WriteLine("Binary object as bytes:");

for (var index = 0; index < binaryObjects.Length; index++)
{
    Console.Write($"{binaryObjects[index]:X} ");
}

Console.WriteLine();

foreach (var binaryObject in binaryObjects)
{
    Console.Write($"{binaryObject:X} ");
}

Console.WriteLine();

string encoded = Convert.ToBase64String(binaryObjects);
Console.WriteLine($"Binary object as string: {encoded}");