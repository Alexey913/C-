int number = new Random().Next (10,100);
Console.WriteLine ($"Наше случайное число:{number}");
int digit1 = number/10;
int digit2 = number%10;
if (digit1 > digit2)
{
    Console.WriteLine ($"Большей является цифра: {digit1}");
}

if (digit1 == digit2)
{
    Console.WriteLine ("Цифры равны");
}
if (digit1<digit2)
{
    Console.WriteLine ($"Большей является цифра: {digit2}");
}