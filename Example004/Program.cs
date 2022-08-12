Console.WriteLine ("Введите число ");
int a = Convert.ToInt32 (Console.ReadLine());
if (a%7==0 && a%23==0)
{
    Console.WriteLine ("Число является кратным 7 и 23");
}
else
{
    Console.WriteLine ("Число не является кратным 7 и 23");
}