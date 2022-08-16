/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number % 100) / 10;
Console.WriteLine(result);







Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");

}
if (number >= 100 && number < 1000)
{
    int result = number % 10;
    Console.WriteLine(result);
}
if (number >= 1000 && number < 10000)
{
    int result = (number % 100) / 10;
    Console.WriteLine(result);

}
if (number >= 10000 && number < 100000)
{
    int result = (number % 1000) / 100;
    Console.WriteLine(result);

}







Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

int  func(int num)
{
    if(num == 6 | num == 7) return 1;
    else return -1;
    
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = func(number);

if (result == 1)
{
    Console.WriteLine("Да");
} 
else
{
    Console.WriteLine("Нет");
}

*/