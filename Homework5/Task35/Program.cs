// Задайте одномерный массив из 123 случайных чисел. // // Определяем диапазон случайных чисел - [0,999] //
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine ("Ниже приведен массив из 123 случайных элементов в диапазоне [0, 999]");
const int size = 123;
int [] array123 = new int [size];
for (int i = 0; i < size; i++)
    {
        array123 [i] = new Random().Next (10, 1000);
//        Console.WriteLine (array123 [i]);
    }
Console.WriteLine ('['+String.Join(", ", array123)+']');
int quantity = 0;
for (int i = 0; i < size; i++)
    {
        if ((array123 [i]>9) && (array123 [i]<100))
        {
            quantity+=1;
        }
    }
Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();
Console.WriteLine ($"Количество элементов массива, значения которых лежат в отрезке [10,99], составляет {quantity}");


// То, что ниже - необязательно для решения этой задачи
Console.WriteLine("Вывести элементы на экран? Y/N");
string answer = Console.ReadLine();

switch (answer.ToLower())
{
    case "y":
    Console.WriteLine ("Значения следующих элементов массива находятся в диапазоне [10, 99]");
    for (int i = 0; i < size; i++)
    {
        if ((array123 [i]>9) && (array123 [i]<100))
        {
            Console.WriteLine ($"Элемент {i} - {array123[i]}");
        }
    }
    break;
    
    case "n":
    Console.WriteLine ("Спасибо!");
    break;

    default:
    Console.WriteLine ("Неверный ввод");
    break;
}