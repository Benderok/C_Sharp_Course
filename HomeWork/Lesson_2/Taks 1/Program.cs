// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.

int a = int.Parse(Console.ReadLine());
int x = a / 10;
int y = x % 10;
Console.WriteLine(y);