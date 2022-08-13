Console.Write("Введите число N, и я определю все чётные числа от 1 до N: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 1;
if (N>0)
{while (count<=N)
    {if (count%2==0)
        {
        Console.WriteLine (count);
        }
        count++;
    }
}
else
    {
        N=-N;
        Console.WriteLine (0);
        while (count<=N)
    {if (count%2==0)
        {
        Console.WriteLine (-count);
        }
        count++;
    }
    }