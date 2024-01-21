//Console.WriteLine ("Ведите число N:");
//int N = Convert.ToInt32 (Console.ReadLine());
//int P = 1;
//for (int i=1; i<=N; i++)
//{
//    P = P*i;
//}
//Console.WriteLine ($"Произведение от 1 до N равно: {P}");



int multiplication (int proizv)
{
    int P = 1;
    for (int i=1; i<=proizv; i++)
    {
        P = P*i;
    }
    return P;
}
Console.WriteLine ("Ведите число N:");
int N = Convert.ToInt32 (Console.ReadLine());
int P = multiplication(N);
Console.WriteLine ($"Произведение от 1 до N равно: {P}");