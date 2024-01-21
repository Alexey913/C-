Console.Write ("Задайте размерность массива:");
int discharge = Convert.ToInt32 (Console.ReadLine());
int [] array = new int [discharge];
Random rand = new Random();
for (int i=0; i<array.Length; i++)
{
    array[i]=rand.Next(-9,10);
}
Console.WriteLine ('['+string.Join(", ", array)+']');
Console.Write ("Введите искомое число:");
int N = Convert.ToInt32 (Console.ReadLine());
int answer = 0;
for (int i=0; i<array.Length; i++)
{
    if (array[i] == N)
    {
        answer=1;
    }
}
if (answer==1)
{
    Console.WriteLine ("");
}
else
{
    Console.WriteLine ("no");
}