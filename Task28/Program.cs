//Напишите программу, которая задает массив из 8 элементов
//и выводит их на экран

void InputArray (int[]array) // Метод для ввода массива со случайными элементами
{
    int length = array.Length;
    for (int i=0; i< length; i++)
    {
        array[i] = new Random().Next(-10000,10001);
    }
}

void PrintArray (int[]print)  // Меиод для вывода массива на экран
{
    int length = print.Length;
    Console.Write ("[");
    for (int j=0; j<length-1; j++)
    {
        Console.Write (print[j]+", ");
    }
    Console.WriteLine (print[length-1]+"]");
}

Console.WriteLine ("У меня есть массив из 8 элементов, и я могу вывести его на экран");
Console.WriteLine ("Нажмите 1, если хотите, чтобы я его показал");
Console.WriteLine ("Нажмите 2, если хотите, чтобы я вывел случайный массив в диапозоне от -10000 до 10000");
Console.WriteLine ("Нажмите 3, если хотите ввести массив вручную");

int request = Convert.ToInt32(Console.ReadLine());

if (request==1)  // Заданный массив
{
    int [] fix = {192, 15, -98, 0, 8475, 433, 980, 653};
    Console.WriteLine ("Вот этот массив: "+'['+string.Join(", ", fix)+']');
}

if (request==2)  //Блок для ввода массива со случайными элементами (добавил возможность выбора размера массива)
{
    Console.WriteLine ("Для начала ввелите размер массива. Напоминаю по условиям задачи размер равен 8!");
    int length = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int[length];
    InputArray (numbers);
    Console.WriteLine ("Вот такой случайный массив:");
    PrintArray (numbers);
}

if (request==3)  //Блок для ввода пользовательского массива (добавил возможность выбора размера массива)
{
    Console.WriteLine ("Для начала ввелите размер массива. Напоминаю по условиям задачи размер равен 8!");
    int length = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write ($"Введите {i+1} элемент массива: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine ("Вот Ваш массив: "+'['+string.Join(", ", numbers)+']');
}

else
{
    Console.WriteLine ("Увы, такого варианта для Вас у меня нет");

}