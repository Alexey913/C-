// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int degree = 1;
int ADegreeB (int a, int b)
{   
    if (b == 0)
    {
        return degree;
    }

    else
    {
        degree = degree*a;
        ADegreeB (a, b-1);
        return degree;
        
    }
}

Console.WriteLine("Введите числа a и b. Я возведу a в степень b");

Console.Write ("Число a равно: ");
int M = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Число b равно: ");
int N = Convert.ToInt32 (Console.ReadLine());

degree = ADegreeB (M, N);
Console.WriteLine (degree);