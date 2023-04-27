// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число
// квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a|| a * a == b )
{
    Console.WriteLine($"{a}, {b} являются квадратом чисел");
} 
else
{
    Console.WriteLine($"{a}, {b} Не является квадратом чисел");
}
