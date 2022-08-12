Console.WriteLine("Ведите номер четверти: ");
string [] answer = {"x>0", "x<0", "y>0", "y<0"};
int quart = Convert.ToInt32(Console.ReadLine());
if (quart == 1)
{
    Console.WriteLine(answer[0]);
    Console.WriteLine(answer[2]);
}
else if (quart == 2)
{
    Console.WriteLine(answer[1]);
    Console.WriteLine(answer[2]);
}
else if (quart == 3)
{
    Console.WriteLine(answer[1]);
    Console.WriteLine(answer[3]);
}
else if (quart == 4)
{
    Console.WriteLine(answer[0]);
    Console.WriteLine(answer[3]);
}
else
{
    Console.WriteLine("Такой четверти не существует!");
}