//Программа перевода из 10 системы счисления в 2 (цикл и массив)


int [] second (int n)
{
    int temp = n;
    int size = 0;
    while (temp>0)
    {
        temp=temp/2;
        size++;
    }
    int [] number = new int [size];
    for (int i=0; i<size; i++)
    {
        number[size-1-i] = n%2;
        n=n/2;
    }
    return number;
}

Console.WriteLine ("Введите число:");
int N = Convert.ToInt32 (Console.ReadLine());

int [] binary = second (N);
Console.Write (string.Join("", binary));