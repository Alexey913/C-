Console.WriteLine ("Введите любое число, и я покажу его третью цифру:");
int a = Convert.ToInt32 (Console.ReadLine());
a = Math.Abs (a);
string b = Convert.ToString(a);

if ((a<100))
{
    Console.WriteLine ("В числе нет третьей цифры!");
}

else 
{
int third = int.Parse (b[2].ToString());
Console.WriteLine($"Третья цифра равна {third}");
}