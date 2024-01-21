﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
   
    markForNew:
Console.WriteLine ("До какого элемента нужно вывести числа Фибоначчи?");
int N = Convert.ToInt32 (Console.ReadLine());


switch (N)
{
    case 0:
    Console.WriteLine ("Неверный ввод");
    break;
    
    case 1:
    Console.WriteLine ("[0]");
    break;
    
    default:
    double [] fibonacci = new double [N];        
    fibonacci [0] = 0;
    fibonacci [1] = 1;
    for (int i = 2; i < N; i++)
    {
        fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
    }
    Console.WriteLine ('[' + String.Join (", ", fibonacci) + ']');
    break;
}
Console.WriteLine ();
Console.WriteLine ("Желаете выполнить повторный ввод? Y/N");
string answer = Console.ReadLine();
switch (answer.ToLower())
{
    case "y":
    goto markForNew;
    break;
    
    case "n":
    Console.WriteLine ("Спасибо!");
    break;
    
    default:
    Console.WriteLine ("Ошибка ввода");
    break;
}