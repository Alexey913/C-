//Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


Console.Write ("Задайте размерность массива:");
int size = Convert.ToInt32 (Console.ReadLine ());

double [] array = new double [size];

for (int i = 0; i < size; i++)
{
    Console.Write ($"Введите {i} элемент массива: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
    Console.WriteLine ();
    Console.WriteLine('[' + String.Join("; ", array) + ']');

double max = array[0];
double min = array[0];
int maxPosition = 0;
int minPosition = 0;
for (int i = 1; i < size; i++)
{
    if (array[i] > max)
    {
        max = array[i];
        maxPosition = i;
    }
    else if (array[i] < min)
    {
        min = array[i];
        minPosition = i;
    }
}
double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет {difference}");

// То, что ниже - необязательно для решения этой задачи

Console.WriteLine("Вывести значения элементов на экран? Y/N");
string answer = Console.ReadLine();

switch (answer.ToLower())
{
    case "y":
    Console.WriteLine ($"Максимальным является элемент {maxPosition} = {max}");
    Console.WriteLine ($"Минимальным является элемент {minPosition} = {min}");
    break;
    
    case "n":
    Console.WriteLine ("Спасибо!");
    break;

    default:
    Console.WriteLine ("Неверный ввод");
    break;
}





//Закомментировано решение, при котором осуществляем заполнение и вывод массива через метод 


// void FillArray (double [] arr)
// {    
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         Console.Write ($"Введите {i} элемент массива: ");
//         arr[i] = Convert.ToDouble(Console.ReadLine());
//     }
// }

// void PrintArray (double [] print)
// {
//     int printLength = print.Length;
//     Console.Write("[");
//     for (int i = 0; i < printLength-1; i++)
//     {
//         Console.Write($"{print[i]}; ");
//     }
//     Console.WriteLine(print[printLength-1]+"]");
// }

// Console.Write ("Задайте размерность массива:");
// int size = Convert.ToInt32 (Console.ReadLine ());

// double [] array = new double [size];

// FillArray (array);
// PrintArray (array);

// Console.WriteLine ("Нажмите Enter для продолжения");
// Console.ReadLine();

// double max = array[0];
// double min = array[0];
// int maxPosition = 0;
// int minPosition = 0;;
// for (int i = 1; i < size; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//         maxPosition = i;
//     }
//     else if (array[i] < min)
//     {
//         min = array[i];
//         minPosition = i;
//     }
// }
// double difference = max-min;
// Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет {difference}");

// // То, что ниже - необязательно для решения этой задачи

// Console.WriteLine("Вывести значения элементов на экран? Y/N");
// string answer = Console.ReadLine();

// switch (answer.ToLower())
// {
//     case "y":
//     Console.WriteLine ($"Максимальным является элемент {maxPosition} = {max}");
//     Console.WriteLine ($"Минимальным является элемент {minPosition} = {min}");
//     break;
    
//     case "n":
//     Console.WriteLine ("Спасибо!");
//     break;

//     default:
//     Console.WriteLine ("Неверный ввод");
//     break;
// }