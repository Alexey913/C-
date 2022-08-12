Console.WriteLine("Введите два числа, и я определю, какое из них большее, а какое меньшее");
Console.Write("Введите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Большим является число: ");
if (Num1>Num2)
{
    Console.WriteLine (Num1);
    Console.Write ("Меньшее, соответственно: ");
    Console.WriteLine (Num2);
}
else
{
    Console.WriteLine (Num2);
        Console.Write ("Меньшее, соответственно: ");
    Console.WriteLine (Num1);
}