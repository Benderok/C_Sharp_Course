//void Sum(int[] numbers, int initialValue)
//{
//    int result = initialValue;
//    foreach (var n in numbers)
//    {
//        result += n;
//    }
//    Console.WriteLine(result);
//}
// 
//int[] nums = { 1, 2, 3, 4, 5, 9};
//Sum(nums, 11);

//void Sum(params int[]  numbers)
//{
//    int result = 0;
//    foreach (var n in numbers)
//    {
//        result += n;
//    }
//    Console.WriteLine("Summ: ");
//    Console.WriteLine(result);
//}
// 
//int[] nums = { 1, 2, 3, 4, 5};
//Sum(nums);
//Sum(1, 2, 3, 4);
//Sum(1, 2, 3);
//Sum();

//void Sum(int initialValue, params int[]  numbers)
//{
//    int result = initialValue;
//    foreach (var n in numbers)
//    {
//        result += n;
//    }
//    Console.WriteLine("Summ: ");
//    Console.WriteLine(result);
//}
// 
//int[] nums = { 1, 2, 3, 4, 5};
//Sum(10, nums);  // число 10 - передается параметру initialValue
//Sum(1, 2, 3, 4);
//Sum(1, 2, 3);
//Sum(20);

//void Increment(ref int n)
//{
//    n++;
//    Console.WriteLine($"Figure in Increment method: {n}");
//}
// 
//int number = 5;
//Console.WriteLine($"Figure before Increment: {number}");
//Increment(ref number);
//Console.WriteLine($"Figure after Increment: {number}");

//void Sum(int x, int y, out int result)
//{
//    result = x + y;
//}
// 
//int number;
// 
//Sum(10, 15, out number);
// 
//Console.WriteLine(number);

//void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
//{
//    rectArea = width * height;       // площадь прямоугольника - произведение ширины на высоту
//    rectPerimetr = (width + height) * 2; // периметр прямоугольника - сумма длин всех сторон  
//}
// 
//int area;
//int perimetr;
// 
//GetRectangleData(10, 20, out area, out perimetr);
// 
//Console.WriteLine($"RectangularArea: {area}");
//Console.WriteLine($"RectangularPerimeter: {perimetr}");

//Напишите программу которая, на вход принимает число и выдает его квадрат.

//Console.WriteLine("Enter number to get its double:");
//var x = Console.ReadLine();
//int N = x == null ? 0 : int.Parse(x);
//Console.Write($"Double of {N} is: ");
//Console.WriteLine(N * N);

// Напишите программу, которая на вход принимает 2 числа и выдает, какое число больше, а какое меньше.

Console.WriteLine("Enter number 1:");
var x = Console.ReadLine();
Console.WriteLine("Enter number 2:");
var y = Console.ReadLine();
int A = int.Parse(x);
int B = int.Parse(y);
int Max = A;
if (B > A)
{
    Max = B;
}
else
{
    Console.WriteLine(Max);
}
Console.WriteLine($"Maximum of {A} and {B} is: ");
Console.WriteLine(Max);
