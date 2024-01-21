Console.WriteLine ("Введите пятизначное число, и я скажу, является ли оно палиндромом:");
int a = Convert.ToInt32 (Console.ReadLine());
a = Math.Abs (a);

if ((a>9999) && (a<100000))
{
    if ((a/10000 == a%10) && ((a/1000)%10 == (a/10)%10))
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine ("Число не является пятизначным");
}