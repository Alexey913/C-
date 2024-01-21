// Задача 25: Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В

Console.WriteLine("Введите два числа A и B, и я возведу A в степень B");
Console.Write("Введите два число A:");
int A = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите два число B:");
int B = Convert.ToInt32 (Console.ReadLine());
int result = 1;
if (B>0)
{for (int i = 0; i<B; i++)
    {
        result = result*A;
    }
Console.Write($"{A} в степени {B} равно {result}");
}
else
{
Console.Write("Число В не является натуральным");   
}