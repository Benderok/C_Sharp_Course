// Напишите программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел.

Console.WriteLine("Enter 3 numbers to know the maximum of it.");
Console.WriteLine("Enter number 1:");
var a = Console.ReadLine();
Console.WriteLine("Enter number 2:");
var b = Console.ReadLine();
Console.WriteLine("Enter number 3:");
var c = Console.ReadLine();
int A = int.Parse(a);
int B = int.Parse(b);
int C = int.Parse(c);
int Max = A;
if (B > Max)
{
    Max = B;
}
if (C > Max)
{
    Max = C;
}
Console.Write($"The maximum is ");
Console.Write(Max);