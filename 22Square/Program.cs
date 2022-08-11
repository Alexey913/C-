Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (n>0)
{
    while (count<n)
    {
        Console.Write ($"{count*count}, ");
        count++;
    }
    Console.WriteLine(n*n);
}
else if (n<0)
{
    while (count>n)
    {
        Console.Write ($"{count*count}, ");
        count= count-1;
    }
    Console.WriteLine(n*n);

}
else
{
    Console.WriteLine (0);
}