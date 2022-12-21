// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void Cross (double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round((k1 * x + b1), 2);
    Console.WriteLine($"Cross point is at x = {x} and y = {y}");
}

Console.WriteLine("Enter b1, k1, b2, k2: ");
Cross(int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine()));