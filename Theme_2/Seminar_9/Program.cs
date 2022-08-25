/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/

/*string NumberPrint(int a, int b)
{
    if(a <= b) return NumberPrint(a, b-1) + $"{b} ";
    else return string.Empty;
}

Console.Write("Введите чило M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write(NumberPrint(number1, number2));*/









/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*int NumberPrint(int a, int b)
{
    if(a <= b) return NumberPrint(a, b-1) + b;
    else return 0;
}

Console.Write("Введите чило M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write(NumberPrint(number1, number2));*/







/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/
            
int Akker(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akker(n - 1, 1);
    if (n > 0 && m > 0) return Akker(n - 1, Akker(n, m - 1));
    return Akker(n,m);
}


Console.Write("Введите чило M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Akker(number2, number1));