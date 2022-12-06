// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

double Distance3D(int ax, int ay, int az, int bx, int by, int bz)
{
    double result;
    result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    return result;
}

int ax = ReadNumber("Enter aX: ");
int ay = ReadNumber("Enter aY: ");
int az = ReadNumber("Enter aZ: ");
int bx = ReadNumber("Enter bX: ");
int by = ReadNumber("Enter bY: ");
int bz = ReadNumber("Enter bZ: ");

Console.WriteLine(Math.Round(Distance3D(ax, ay, az, bx, by, bz), 2));