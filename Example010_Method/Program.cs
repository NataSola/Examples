int[] array = { 1, 2, 18, 4, 5, 6, 18, 8 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] ==  find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}