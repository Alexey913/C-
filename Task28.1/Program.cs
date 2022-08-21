//Напишите программу, в которой задается массив чисео
//и выдается произведение от 1 до N для каждого элемента

void InputArray (int[]array)  // Метод для ввода массива со случайными элементами
{
    int length = array.Length;
    for (int i=0; i< length; i++)
    {
        array[i] = new Random().Next(-10,11);
    }
}

void PrintArray (int[]print)  // Метод для вывода массива
{
    int length = print.Length;
    Console.Write ("[");
    for (int j=0; j<length-1; j++)
    {
        Console.Write (print[j]+", ");
    }
    Console.WriteLine (print[length-1]+"]");
}

void MultiplicateArray (int[]numbers, int[]multiplicate)  // Метод для умножения элементов массива
{
    
    int temp = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        multiplicate[i] = numbers[i];
        temp = Math.Abs(numbers[i]);
        for (int j = 1; j < temp; j++)
        {
            multiplicate[i] = j * multiplicate[i];
        }
    }
}

Console.WriteLine ("У меня есть массив из 8 элементов, и я могу вывести его на экран");
Console.WriteLine ("Нажмите 1, если хотите, чтобы я его показал");
Console.WriteLine ("Нажмите 2, если хотите, чтобы я вывел случайный массив в диапозоне от -10 до 10");
Console.WriteLine ("Нажмите 3, если хотите ввести массив вручную");

int request = Convert.ToInt32(Console.ReadLine());  // Выбор варианта ввода

if (request==1)  // Умножение элементов предустановленного массива
{
    int [] fix = {9, 5, 8, 0, 3, 4, 2, 6};
    Console.WriteLine ("Вот этот массив: ");
    Console.WriteLine ('['+string.Join(", ", fix)+']');
    int [] multiplicate = new int [fix.Length];
    for (int i = 0; i < fix.Length; i++)
    {
        multiplicate[i] = fix[i];
        for (int j = 1; j < fix[i]; j++)
        {
            multiplicate[i] = j * multiplicate[i];
        }
    }
    Console.WriteLine ("А это массив с произведениями от 1 до N: ");
    Console.WriteLine ('['+string.Join(", ", multiplicate)+']');

}

if (request==2)  // Умножение жлементов массива со случайными элементами с возможностью ввода размера массива
{
    Console.WriteLine ("Для начала ввелите размер массива. Напоминаю, что по условиям задачи размер равен 8!");
    int length = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int[length];
    InputArray (numbers);
    Console.WriteLine ("Вот такой случайный массив:");
    PrintArray (numbers);
    int [] multiplicate = new int [numbers.Length];
    MultiplicateArray (numbers, multiplicate);
    Console.WriteLine ("А это массив с произведениями от 1 до N: ");
    // PrintArray (multiplicate);
    Console.WriteLine ('['+string.Join(", ", multiplicate)+']');
}

if (request==3)  // Умножение жлементов массива пользователя с возможностью ввода размера массива
{
    Console.WriteLine ("Для начала ввелите размер массива. Напоминаю, что по условиям задачи размер равен 8!");
    int length = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write ($"Введите {i+1} элемент массива: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine ("Вот Ваш массив: ");
    Console.WriteLine ('['+string.Join(", ", numbers)+']');
    int [] multiplicate = new int [numbers.Length];
    MultiplicateArray (numbers, multiplicate);
    Console.WriteLine ("А это массив с произведениями от 1 до N: ");
    Console.WriteLine ('['+string.Join(", ", multiplicate)+']');
}

else
{
    Console.WriteLine ("Увы, такого варианта для Вас у меня нет");

}