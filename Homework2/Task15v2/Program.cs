Console.WriteLine("Введите номер дня недели, и я скажу, выходной это, или нет:");
int a = Convert.ToInt32 (Console.ReadLine());
if (a>0 && a<6)
{
    Console.WriteLine ("Увы, это не выходной");
}

else if (a>5 && a<8)    
{
    Console.WriteLine ("Выходной!");
}

else
{
    Console.WriteLine ("Увы, в неделе всего лишь 7 дней");
}