int number = new Random().Next (100,1000);
Console.WriteLine ($"Наше случайное число:{number}");
int digit1 = number/100;
int digit2 = number%10;
Console.Write (digit1);
Console.Write (digit2);