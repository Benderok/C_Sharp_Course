// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter number to know if is even or odd.");
Console.WriteLine("Enter number: ");
var a = Console.ReadLine();
int A = int.Parse(a);
if (A % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}