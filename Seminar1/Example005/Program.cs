Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
if (N>0)
{
    while (count<=N)
    {
        Console.Write (count);
        count=count+1;
    }
}
else
{
  while (count>=N)
    {
        Console.Write (count);
        count=count-1;
    }  
}