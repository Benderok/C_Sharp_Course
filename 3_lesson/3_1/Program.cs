// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

void Range(string i)
{
    if (i == "I")
        Console.WriteLine("x > 0 && y > 0");
    else if (i == "II")
        Console.WriteLine("x < 0 && y > 0");
    else if (i == "III")
        Console.WriteLine("x < 0 && y < 0");
    else if (i == "IV")
        Console.WriteLine("x > 0 && y < 0");
}

Range(Console.ReadLine());