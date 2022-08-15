//Сколько цифр в числе?


//int metod (int n)
//{
//    string num = Convert.ToString(n);
//    int length = num.Length;
//    return length;
//}

//Console.WriteLine ("Введите число:");
//int number = Convert.ToInt32(Console.ReadLine());
//int abs = Math.Abs (number);
//int length = metod (abs);
//Console.WriteLine (length);




Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int abs = Math.Abs (number);
int count = 0;
while (abs>0)
{
    abs = abs/10;
    count = count+1;
}

Console.WriteLine (count);


