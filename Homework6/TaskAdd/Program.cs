//Дополнительная задача на рекурсию
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120

double Factorial (double number)
{
    if (number==1) return 1;
    else return number*Factorial(number-1);
}


Console.Write ("Введите число, для которого нужно посчитать факториал: ");
double N = Convert.ToInt32 (Console.ReadLine());

double factorial = Factorial(N);
Console.WriteLine ($"Произведение чисел от 1 до N равно: {factorial}");
