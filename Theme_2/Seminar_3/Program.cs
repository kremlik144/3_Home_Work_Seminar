/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
char [] arr = n.ToString().ToCharArray();    // преобразовал число в массив

int count = 0;   
int index2 = 1;          
for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] == arr[^index2]) count++;     // сравниваю первую цифру с последней и так до цифры посередине числа
    index2++;
    if(count == 3) break;
}
if(count == 3) Console.Write("да");
else Console.Write("нет");




/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координаты точки А");
Console.Write("Введите координаты x: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите координаты точки В");

Console.Write("Введите координаты x: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между двумя точками в пространстве равно: " + distance);





/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void func(int x)
{
    for(int i = 1; i <= x; i++)
    {
        int res = i*i*i;
        if(i == x)
        {
            Console.Write(res);
            break;
        }
        Console.Write(res + ", ");
    }
}

func(N);