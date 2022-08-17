/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*void FillArray(double [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            Random rand = new Random();
            math[i,j] = Math.Round( new Random().Next(-5,9) + rand.NextDouble(), 1);
        }
    }
}
void PrintArray(double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк двумерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int y = Convert.ToInt32(Console.ReadLine());

double [,] array = new double[x,y];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();*/















/*Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном
массиве, и возвращае тзначение либо индекс этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
2, 3 -> такой элемент есть и равен 4
5, 5 -> такой элемент отсутствует*/

/*void FillArray(int [,] math, int number)
{
    int flag = 0;
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            math[i,j] = new Random().Next(1,9);
            if(math[i,j] == number) Console.WriteLine($"Элемент {number}, есть в массиве. Строка= {i+1}, столбец= {j+1}");
            else flag++;
        }
    }
    if(flag == math.Length) Console.WriteLine($"Элемента {number}, нет в массиве!");
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение которое хотите найти в массиве: ");
int result = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[x,y];

Console.WriteLine();
FillArray(array, result);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();*/











/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

/*void FillArray(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            math[i,j] = new Random().Next(1,15);
        }
    }
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageValue(int [,] math)
{
    for(int i = 0; i < math.GetLength(1); i++)
    {
        double result = 0.0;
        for(int j = 0; j < math.GetLength(0); j++)
        {
            result+= math[j,i];
        }
        Console.WriteLine($"Среднееарифметическое {i+1} cтолбца = {Math.Round((result / math.GetLength(0)), 2)}");
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int y = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[x,y];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
AverageValue(array);*/