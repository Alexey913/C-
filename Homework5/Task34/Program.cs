// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray (int [] arr)
{    
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
}

void PrintArray (int [] print)
{
    int printLength = print.Length;
    Console.Write("[");
    for (int i = 0; i < printLength-1; i++)
    {
        Console.Write($"{print[i]}, ");
    }
    Console.WriteLine($"{print[printLength-1]}]");
}

Console.WriteLine ("Задайте размерность массива положительных трехзначных чисел.");
Console.WriteLine ("Я заполню его случайными элементами и определю количество четных элементов.");
Console.WriteLine ("Сколько элементов будет в массиве?");
int size = Convert.ToInt32 (Console.ReadLine ());
int [] array = new int [size];
FillArray (array);
PrintArray (array);
int countEven = 0;
for (int i = 0; i < size; i++)
{
    if (array [i]%2 == 0)
    {
        countEven = countEven+1;
    }
}

Console.WriteLine($"Количество четных элементов массива равно {countEven}");

// То, что ниже - необязательно для решения этой задачи (выводим четные элементы по запросу)
Console.WriteLine("Вывести элементы на экран? Y/N");
string answer = Console.ReadLine();
switch (answer.ToLower())
{
    case "y":
    Console.Write ("Четные элементы массива: [ ");
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i]%2 == 0)
            {
                Console.Write($"{array[i]} ");
            }
        } 
    Console.WriteLine("]");
    break;
    
    case "n":
    Console.WriteLine ("Спасибо!");
    break;

    default:
    Console.WriteLine ("Неверный ввод. Выполнение завершено");
    break;
}