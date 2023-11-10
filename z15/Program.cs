// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int a = Convert.ToInt32(Console.ReadLine());

if (a > 7 || a < 1)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    if (a < 5)
    {
        System.Console.WriteLine("нет");
    }
    else
    {
        System.Console.WriteLine("да");
    }
}