// Задача №11
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000);
int a = number / 100;
int b = number % 10;
Console.WriteLine($"{number}");
Console.WriteLine($"{a}{b}");
