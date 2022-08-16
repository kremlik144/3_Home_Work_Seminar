/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
Console.Write("Введите размерность массива N: ");
int sitze = Convert.ToInt32(Console.ReadLine());
int [] array = new int[sitze];
int result = 0;
for(int i = 0; i < sitze; i++)
{
    array[i] = new Random().Next(100, 1000);
    if(array[i] % 2 == 0) result++;
}
Console.WriteLine($"Количчество четных чисел в массиве = {result}");
Console.WriteLine();
Console.Write("Заданный массив: ");
PrintArray(array);*/









/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
Console.Write("Введите размерность массива N: ");
int sitze = Convert.ToInt32(Console.ReadLine());
int [] array = new int[sitze];
int result = 0;
for(int i = 0; i < sitze; i++)
{
    array[i] = new Random().Next(-10, 10);
    if(i % 2 != 0) result += array[i];
}
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях = {result}");
Console.WriteLine();
Console.Write("Заданный массив: ");
PrintArray(array);*/












/*Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и
минимальным элементов массива.
[3 7 22 2 78] -> 76

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
Console.Write("Введите размерность массива N: ");
int sitze = Convert.ToInt32(Console.ReadLine());
int [] array = new int[sitze];
for(int i = 0; i < sitze; i++)
{
    array[i] = new Random().Next(0, 100);
}
int min = array[0];
int max = array[1];
for(int i = 0; i < array.Length; i++)
{
    if(array[i] < min) min = array[i];
    if(array[i] > max) max = array[i];
}
Console.WriteLine($"Разница между максимальным иминимальным элементов массива = {max - min}");
Console.Write("Заданный массив: ");
PrintArray(array);*/