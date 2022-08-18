Console.Write ("Задайте размерность массива:");
int discharge = Convert.ToInt32 (Console.ReadLine());
int [] array = new int [discharge];
Random rand = new Random();
for (int i=0; i<array.Length; i++)
{
    array[i]=rand.Next(-1000,1000);
}
Console.WriteLine ('['+string.Join(", ", array)+']');
for (int i=0; i<array.Length; i++)
{
    array [i]=-array[i];
}
Console.WriteLine ('['+string.Join(", ", array)+']');