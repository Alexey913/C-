// Задача 36: Задайте одномерный массив, заполненный случайными числами. // Принимаем диапазон [-100, 100] //
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray (int [] arr)
{    
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-100,101);
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
    Console.WriteLine(print[printLength-1]+"]");
}

Console.WriteLine ("Задайте размерность массива, я заполню его случайными элементами в диапазоне [-100; 100]");
int size = Convert.ToInt32 (Console.ReadLine ());
int [] array = new int [size];

FillArray (array);
PrintArray (array);

Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();

int sumNotEvenPosition = 0;
for (int i = 1; i < size; i+=2)
{
    sumNotEvenPosition+=array[i];
}
Console.WriteLine ($"Сумма элементов массива, стоящих на нечетных позициях, составляет {sumNotEvenPosition}");

// То, что ниже - необязательно для решения этой задачи

Console.WriteLine("Вывести элементы на экран? Y/N");
string answer = Console.ReadLine();

switch (answer.ToLower())
{
    case "y":
    Console.WriteLine ("Значения элементов массива, стоящих на нечетных позициях");
    for (int i = 1; i < size; i+=2)
    {
        Console.WriteLine ($"Элемент {i} - {array[i]}");
    }
    break;
    
    case "n":
    Console.WriteLine ("Спасибо!");
    break;

    default:
    Console.WriteLine ("Неверный ввод");
    break;
}