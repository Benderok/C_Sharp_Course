// Задайте значение N. Напишите программу, которая выведет все четные натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void EvenNumbers(int n)
{
    if (n <= 0) return;
    if (n % 2 != 0) n -= 1;
    Console.Write($" {n} ");
    EvenNumbers(n - 2);
}
EvenNumbers(21);