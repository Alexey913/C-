//Программа перевода из 10 системы счисления в 2 (рекурсия)

void binary (int N)
{
    if (N<=0) return;
    binary(N/2);
    Console.Write(N%2);
}

Console.WriteLine ("Введите число:");
int number = Convert.ToInt32 (Console.ReadLine());

binary (number);