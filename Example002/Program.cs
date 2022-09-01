void PrintNumbers (int M, int N)
{
    
    // int min = M;
    // int max = N;
    // if (M > N)
    // {
    //     min = N;
    //     max = M;
    // }
    // if (min == max-1)
    // {
    //     return;
    // }
    // else 
    // {
    //     PrintNumbers(min, max-1);
    //     Console.Write ($"{max} ");
    // }
    
    if (N == M-1)
    {
        return;
    }
    else 
    {
    PrintNumbers(M, N-1);
    Console.Write ($"{N} ");
    }
}

Console.WriteLine ("Введите числа M и N, и я выведу все натуральные числа от M до N");
Console.Write ("Число M равно: ");
int M = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Число N равно: ");
int N = Convert.ToInt32 (Console.ReadLine());

if (M < N)
{
    PrintNumbers(M, N);
}
else
{
    PrintNumbers(N, M);
}