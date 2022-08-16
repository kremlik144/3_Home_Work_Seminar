/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int x2 = Convert.ToInt32(Console.ReadLine());

if (x1 > x2)
{
   Console.Write("max = ");
   Console.WriteLine(x1); 
}
else
{
   Console.Write("max = ");
   Console.WriteLine(x2);  
}*/



/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.WriteLine("Введите первое число");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int x3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (x1 > max)
{
    max = x1;
}
if (x2 > max)
{
    max = x2;
}
if (x3 > max)
{
    max = x3;
}

Console.Write("Максимальное число = ");
Console.WriteLine(max);*/



/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число
чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if((x%2) == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}*/




/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает
все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

/*Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int result = 2;

if (x > 1)
{
    while(result <= x)
    {
       Console.Write(result);
       Console.Write(" ");
       result = result + 2; 
    } 
}
else
{
    Console.Write("Четных чисел нет");
}*/