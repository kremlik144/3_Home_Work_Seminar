/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/

/*void FillArray(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            math[i,j] = new Random().Next(1,20);
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

void SortingLine(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int count = 0; count < math.GetLength(1); count++)
        {
            for(int j = 0; j < math.GetLength(1)-1; j++)
            {
                if( math[i,j]> math[i,j+1])
                {
                    int max = math[i,j];
                    math[i,j] = math[i,j+1];
                    math[i,j+1] = max;
                } 
            }
        }
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
SortingLine(array);
PrintArray(array);*/






/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
суммой элементов: 1 строка*/

/*void FillArray(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            math[i,j] = new Random().Next(1,10);
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

int LineMinimumSumm(int [,] math)
{
    int ValueMinLine = 0;
    int MinIndex = 0;

    for(int k = 0; k < math.GetLength(1); k++)
    {
        ValueMinLine += math[0,k];
    }

    for(int i = 1; i < math.GetLength(0); i++)
    {
        int SummNewLine = 0;
        for(int j = 0; j < math.GetLength(1); j++) SummNewLine += math[i,j];

        if(ValueMinLine > SummNewLine)
        {
            ValueMinLine = SummNewLine;
            MinIndex = i;
        }
    }
    return MinIndex;
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
Console.WriteLine($"Строка - {LineMinimumSumm(array)+1} имеет наименьшую сумму элементов ");*/







/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

/*void FillArray(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            math[i,j] = new Random().Next(1,10);
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

void MatrixMultiplication(int [,] array1, int [,] array2, int [,] array3)
{
    int value = 0;
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            value = array1[i,j] * array2[i,j];
            array3[i,j] = value;
            value = 0;
        }
    }
}



Console.Write("Введите количество строк двумерного массива N и M : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива N и M: ");
int y = Convert.ToInt32(Console.ReadLine());

int [,] FirstArray = new int [x,y];
int [,] SecondArray = new int[x,y];
int [,] ResultArray = new int[x,y];

Console.WriteLine();

FillArray(FirstArray);
FillArray(SecondArray);

PrintArray(FirstArray);
Console.WriteLine();
PrintArray(SecondArray);
Console.WriteLine();
MatrixMultiplication(FirstArray, SecondArray, ResultArray);
Console.WriteLine("Произвебение матриц M и N показано ниже :");
PrintArray(ResultArray);*/
