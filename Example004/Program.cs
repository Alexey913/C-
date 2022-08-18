Console.Write ("Задайте размерность массива:");
int discharge = Convert.ToInt32 (Console.ReadLine());
int [] array = new int [discharge];
int N = 0;
Random rand = new Random();
for (int i=0; i<array.Length; i++)
{
    array[i]=rand.Next(-9,10);
}
Console.WriteLine ('['+string.Join(", ", array)+']');
if (discharge%2 == 0)
{
    N=0;
}
else
{
    N=1;
}
int [] result = new int[array.Length/2+N];
if (array.Length%2==0)
   {
        for (int i=0; i<array.Length/2; i++)
        {
            result[i]=array[i]*array[array.Length-1-i];
        }
    }
else
    {
        for (int i=0; i<array.Length/2; i++)
        {
            result[i]=array[i]*array[array.Length-1-i];
        
            result[array.Length/2]=array[array.Length/2];
        }
    }
Console.WriteLine ('['+string.Join(", ", result)+']');