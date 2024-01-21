Console.WriteLine ("Введите два числа, и я определю, являются ли они кратными");
Console.WriteLine ("Введите первое число ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число ");
int b = Convert.ToInt32 (Console.ReadLine());
if (b%a==0)

{
    Console.WriteLine ($"Число {b} является кратным числу {a}");
}

else 
{
    Console.WriteLine ($"Число {b} не является кратным числу {a}");
    Console.Write ("Остаток от деления равен: ");
    Console.WriteLine (a%b);
}