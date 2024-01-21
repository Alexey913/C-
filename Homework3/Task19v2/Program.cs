Console.WriteLine ("Введите пятизначное число, и я скажу, является ли оно палиндромом:");
int a = Convert.ToInt32 (Console.ReadLine());
a = Math.Abs (a);
string b = Convert.ToString(a);
if ((a > 9999) && (a < 100000))
{   int first = int.Parse (b[0].ToString());
    int second = int.Parse (b[1].ToString());
    int fourth = int.Parse (b[3].ToString());
    int fifth = int.Parse (b[4].ToString());
    if ((first==fifth) && (second == fourth))
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