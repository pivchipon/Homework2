/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

/*int number = new Random().Next(100,1000);
Console.WriteLine(number);
int result = (number/10 %10);
Console.WriteLine(result);*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/


/*int Number = new Random().Next(1, 1500);
Console.WriteLine();
Console.WriteLine($"given a number {Number}");
if (Number / 100 < 1)
{
    Console.WriteLine($"There is no third digit");
}
else
{
    if (Number / 1000 >= 1)
    {
        Console.WriteLine($"The first digit of {Number} is {Number / 10 % 10}");
    }
    else
    {
        Console.WriteLine($"The first digit of {Number} is {Number % 10}");
    }
}
System.Console.WriteLine();*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/


Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("There is no such day of the week");
}
else if (number == 6 || number ==7)
{
    Console.WriteLine("This is a holiday");
}
else
{
    Console.WriteLine("It is not a holiday");
}








