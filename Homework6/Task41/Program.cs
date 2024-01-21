// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3   

Console.WriteLine ("Введите несколько чисел, и я скажу, сколько среди них положительных");
        markUncorrect:
Console.WriteLine ("Сколько чисел будете вводить?");
int M = Convert.ToInt16 (Console.ReadLine());
if (M > 0)
{   
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.Write ($"Введите число {i+1}: ");
        int number = Convert.ToInt32 (Console.ReadLine());
        if (number > 0) count++;
    }
    Console.WriteLine ($"Количество чисел больше 0 среди введенных Вами составляет {count} из {M}");
}
else
{
    Console.WriteLine ("Некорректный ввод!");
    goto markUncorrect;
}
