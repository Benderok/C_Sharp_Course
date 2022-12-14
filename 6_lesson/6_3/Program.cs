// Выведите первые N чисел Фибоначчи.

void Fibonacci(int n)
{
    int a = 0, b = 1;

    for (int i = 0; i < n; i++)
    {
        Console.Write($"{a}, ");
        (a, b) = (b, a + b);
    }
}

int n = int.Parse(Console.ReadLine());
Fibonacci(n);