// Напишите программу, которая на вход принимает 2 числа и выдает, какое число больше, а какое меньше.

Console.WriteLine("Enter number 1:");
var x = Console.ReadLine();
Console.WriteLine("Enter number 2:");
var y = Console.ReadLine();
int A = int.Parse(x);
int B = int.Parse(y);
int Max = A;
if (B > A)
{
    Max = B;
}
else
{
    Console.WriteLine(Max);
}
Console.WriteLine($"Maximum of {A} and {B} is: ");
Console.WriteLine(Max);
