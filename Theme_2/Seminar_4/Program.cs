/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/*Console.Write("Введите чило А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 1; i <= number2; i++)
    {
        result *= number1;
    }
Console.WriteLine(result);*/











/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/*Console.Write("Введите чило N: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int result = 0;
while(number1 != 0)
    {
        result += number1 % 10;
        number1 = number1 / 10;
    }
Console.WriteLine(result);*/








/*Задача 29: (необязательная) Напишите программу, которая создает массив из введенных через запятую цифр 
и выводит этот массив на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

/*void PrintArray(string [] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        if(position == 0) Console.Write($"[{col[position]}, ");
        if(position > 0 && position < col.Length -1) Console.Write($"{col[position]}, ");
        if(position == col.Length -1) Console.Write($"{col[position]}]");
        
        position++;
    }
}
Console.Write("Введите чила через запятую: ");
string number = Console.ReadLine();
string [] result = number.Split(", ");
PrintArray(result);
//Console.Write($"[{result[1]}]");*/