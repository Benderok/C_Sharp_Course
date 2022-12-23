// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

int Summa(int a, int b)
{
    if (a < b) return (a==b)?b:a + Summa(a+1,b);
    else if (a == b) return a;
    else return 0;
}
Console.WriteLine(Summa(1, 8));