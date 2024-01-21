// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b*b==a)
{
    Console.WriteLine ("Да ");
}
else
{
    Console.WriteLine ("Нет ");
}