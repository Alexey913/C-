Console.WriteLine("Введите три числа, и я определю максимальное");
Console.Write("Введите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int Num3 = Convert.ToInt32(Console.ReadLine());
int max=Num1;
if (Num2>max)
{
    max=Num2;
}
if (Num3>max)
{ 
    max=Num3;
}
Console.Write ("Большим является число: ");
Console.WriteLine (max);