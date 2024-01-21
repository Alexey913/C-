Console.WriteLine("Введите три числа, и я скажу,есть ли треугольник с такими сторонами");
Console.WriteLine("Введите число A");
int A = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число C");
int C = Convert.ToInt32 (Console.ReadLine());
if ((A<=0)||(B<=0)||(C<=0))
{
    Console.WriteLine("Длина не может быть меньше или равна 0!");
}
else
{
    if ((A+B>C)&&(B+C>A)&&(A+C>B))
    {
        Console.WriteLine("Треугольник с такими длинами сторон существует");
    }
    else
    {
        Console.WriteLine("Треугольник с такими длинами сторон не существует");
    }
}