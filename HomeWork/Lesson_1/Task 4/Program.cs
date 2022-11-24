// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 2 до N.

Console.WriteLine("Enter number: ");
var a = Console.ReadLine();
int A = int.Parse(a);
Console.WriteLine("Result:");
for (int N = 2; N <= A; N += 2)
{
    Console.Write(N);
    if (N == A)
        continue;
    Console.Write(",");
}