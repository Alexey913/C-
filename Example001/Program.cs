void PrintNumbers (int N)
{
    if (N==0)
    {
        return;
    }
    else 
    {
    PrintNumbers(N-1);
    Console.Write ($"{N} ");
    }
}
Console.WriteLine ("Введите число N, и я выведу все натуральные числа от 1 до N");
int N = Convert.ToInt32 (Console.ReadLine());

PrintNumbers(N);