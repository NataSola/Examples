// Сортировка чисел массива по возрастанию

int[] arr = { 1, 5, 8, 3, 4, 9, 1, 5, 7, 8, 2 };

void PrintArray(int[] array)            // метод для вывода массива на печать
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)         //  метод для сортировки массива 
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)  // если длина-1, то не берется последний элемент массива
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectSort(int[] array)         //  метод для сортировки массива 
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)  // если длина-1, то не берется последний элемент массива
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

SelectSort(arr);
PrintArray(arr);