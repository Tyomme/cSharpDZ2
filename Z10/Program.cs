// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000)
{
    a = a /10;
    a = a %10;
    System.Console.WriteLine(a);
}
else 
System.Console.WriteLine("Вы ввели не трехзначное число!");

