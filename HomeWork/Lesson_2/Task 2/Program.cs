// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

//int Middle (int num)
//{
//    Console.WriteLine(num);
//    x = num % 10;
//    y = x % 10;
//    z = x / 100 * 10;
//    result = z + y;
//}
//
//Console.WriteLine(Middle(new Random().Next(99, 1000)));


int x = new Random().Next(100,1000);
int y = x % 10;
int z = x / 100 * 10;
int result = z + y;
Console.WriteLine(x);
Console.WriteLine(result);