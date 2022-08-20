// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе


// Представим число в виде массива и найлем сумму его элементов
Console.WriteLine("Введите любое целое число, и я покажу сумму его цифр");
int num = Convert.ToInt32 (Console.ReadLine());
int abs = Math.Abs (num); // при преобразовании в строку для подсчета длины
                          // предполагаемого массива исключаем минус из подсчета
string textAbs = Convert.ToString (abs);  // переменная для подсчёта длины массива
int discharge = 1;                        // переменная понадоьится для преобразования
                                          // числа в отдельные цифры
int length = textAbs.Length;              // считаем длину предполагаемого массива
int sum = 0;                              // сюда будем считать сумму цифр числа
int [] numToArray = new int[length];      // задаем массив
for (int i = 0; i < length; i++)          // цикл для заполнения массива
    {
        numToArray[length-1-i] = abs%(discharge*10)/discharge;  // переводим каждый
                                                                // разряд числа в отдельную
                                                                // цифру
        discharge=discharge*10;
    }
if (num < 0)                              // возвращаем отрицательное значение
                                          // первому элементу, если число отрицательное
{
    numToArray[0]=-numToArray[0];
}
for (int i = 0; i < length; i++)          // цикл для подсчёта суммы цифр
    {
        sum+=numToArray[i];
    }
Console.WriteLine ("Число сосотит из следующих цифр: "+'['+string.Join(", ", numToArray)+']');
Console.WriteLine($"Сумма цифр числа равна: {sum}");