Console.WriteLine("Введите трехзначное число ");
int N = Convert.ToInt32(Console.ReadLine());
if (N>99&&N<1000||N>-1000&&N<-99)
{
int div=Math.Abs(N%10);
Console.Write("Последняя цифра в числе равна ");
Console.WriteLine(div);
}
else
{
Console.WriteLine("Число не является трехзначным");
}

