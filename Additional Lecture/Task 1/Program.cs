// A в степени n

int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    //if (n == 0) return 1;
    //return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(2, 10));

//Факториал числа

int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n -1);
}

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

Console.WriteLine(Factorial(10));
Console.WriteLine(FactorialFor(10));
