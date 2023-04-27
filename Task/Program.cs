// Демонстрация решения
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

//1. Гернирация случайного числа.
//2. Найти наибольшую цифру числа.
//3. Вывод.

Random rand = new Random();
int number = rand.Next(10, 100);
int a = number / 10;
int b = number % 10;
if (a > b)
{
    Console.WriteLine($"Our number is {number}. {a} > {b}. Result");
}
else if (a < b)
{
    Console.WriteLine($"Our number is {number}. {b} > {a}. Result");

}
else
{
    Console.WriteLine($"Our number is {number}. {a} = {b}");
}

