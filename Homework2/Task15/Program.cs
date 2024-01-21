Console.WriteLine("Введите номер дня недели, и я скажу, выходной это, или нет:");
int a = Convert.ToInt32 (Console.ReadLine());
switch (a)
{
    case 1:
    Console.WriteLine ("Это понедельник - не выходной");
    break;
    
    case 2:
    Console.WriteLine ("Это вторник - не выходной");
    break;

    case 3:
    Console.WriteLine ("Это среда - не выходной");
    break;

    case 4:
    Console.WriteLine ("Это четверг - не выходной");
    break;

    case 5:
    Console.WriteLine ("Это пятница - не выходной");
    break;

    case 6:
    Console.WriteLine ("Это суббота - выходной!");
    break;

    case 7:
    Console.WriteLine ("Это воскресенье - выходной!");
    break;

    default:
    Console.WriteLine ("Увы, в неделе всего лишь 7 дней");
    break;
}