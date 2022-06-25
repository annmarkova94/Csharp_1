Console.Clear();

Console.Write("Insert numberA: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Insert numberB: ");
int numberB = int.Parse(Console.ReadLine());
if (numberB == numberA * numberA)
{
    Console.WriteLine("Yes, numberB = numberA*numberA");
}
else
{
    Console.WriteLine("No, numberB != numberA*numberA");
}