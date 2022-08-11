Console.WriteLine("Введите трехзначное число, и я покажу его вторую цифру");
int a = Convert.ToInt32 (Console.ReadLine());
if ((a>99 && a<1000) || (a>-1000 && a<-99))
{
    int second = Math.Abs((a-a/100*100-a%10)/10);
    Console.WriteLine ($"Вторая цифра числа равна {second}");
}
else
{
    Console.WriteLine ("Число не является трехзначным ");
}