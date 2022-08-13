Console.WriteLine("Введите число, и я определю, чётное оно, или нет: ");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num%2==0)
{
    Console.WriteLine ("Да, число является чётным");
}
else
{ 
    Console.WriteLine ("Нет, число не является чётным");
}