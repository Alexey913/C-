Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());
//if (a*a==b || b*b==a)
//{
//   Console.WriteLine ("Да");
//}
//else
//{  
//    Console.WriteLine ("Нет");
//}
if (a*a==b)
{
    Console.WriteLine ("Второе число является квадратом первого");
}
if (b*b==a)
{
    Console.WriteLine ("Перове число является квадратом второго");
}
else 
{
    Console.Write ("Ни одно число не является квадратом другого");
}