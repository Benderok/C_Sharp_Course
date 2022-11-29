// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

String Middle(int num)
{
    Console.WriteLine(num);
    int y = num % 10;
    int z = num / 100;
    return z.ToString() + y.ToString();
}

Console.WriteLine(Middle(new Random().Next(100, 1000)));