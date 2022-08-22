// Задача на переворот массива

const int ARRAY_SIZE = 12;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

int [] FillArray (int ARRAY_SIZE, int LEFT_RANGE, int RIGHT_RANGE)
{
    Random rand = new Random();
    int [] arr = new int [ARRAY_SIZE];
    for (int i = 0; i < ARRAY_SIZE; i++)
    {
        arr[i] = rand.Next(LEFT_RANGE, RIGHT_RANGE+1);
    }
    return arr;
}

void reversArray (int [] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        temp = arr [i];
        arr [i] = arr [arr.Length-1-i];
        arr [arr.Length-1-i] = temp;
    }
} 
    
int [] array = FillArray (ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine ('['+String.Join(",", array)+']');
reversArray (array);
Console.WriteLine ('['+String.Join(",", array)+']');