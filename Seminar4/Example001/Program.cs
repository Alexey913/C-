//Сумма от 1 до А
int Cycle (int a)
{
    int sum = 0;
    for (int i =1; i<=a; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine ("Input number A: ");
int number = Convert.ToInt32 (Console.ReadLine());
int sum = Cycle (number);
Console.WriteLine ($"Sum is: {sum}");