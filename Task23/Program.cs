Console.WriteLine("Введите число N, и я выведу таблицу кубов от 1 до N");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (n>0)
{
    while (count<n)  // использую строгое неравенство, чтобы осуществить вывод через запятую, как в примере к задаче
                     // и при этом избавиться от запятой в конце ряда
                     // можно заменить строки 10, 11, 12 на Console.WriteLine ($"{Math.Pow(count,3)}, "),
                     //поставив в условии нестрогое неравенство
    {
        Console.Write ($"{Math.Pow(count,3)}, ");
        count++;
    }
    Console.WriteLine(Math.Pow(count,3));
}
else if (n<0)
{
    while (count>n)  // то же, что в строке 6, для возможности использования отрицательных чисел
                     // при этом выводится тот же ряд, что и для положительных,
                     // только внчале добавляем 1 и 0, чтобы соблюсти условие задачи (от 1 до N)
    {
        Console.Write ($"{Math.Pow(count,3)}, ");
        count = count-1;
    }
    Console.WriteLine(Math.Pow(count,3));

}
else
{
    Console.WriteLine (0);
}