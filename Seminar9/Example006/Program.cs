int ADegreeB (int a, int b)
{   
    if (b == 0)
    {
        return 1;
    }

    return a*ADegreeB(a, b-1);
        
}


Console.WriteLine("Введите числа a и b. Я возведу a в степень b");

Console.Write ("Число a равно: ");
int M = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Число b равно: ");
int N = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine (ADegreeB (M, N));