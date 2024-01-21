void InputArray (int[]array)
{
    int length = array.Length;
    for (int i=0; i< length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
}

void PrintArray (int[]print)
{
    int length = print.Length;
    for (int j=0; j<length; j++)
    Console.Write (print[j]+", ");
}

// Console.WriteLine('[' + string.Join(", " , Array(N,min,max)) + ']');

int [] numbers = new int[8];
InputArray (numbers);
PrintArray (numbers);