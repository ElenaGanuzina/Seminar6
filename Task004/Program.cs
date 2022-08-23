// 45. Копия заданного массива, с помощью поэлементного копирования.

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array [i];
    }
    return array2;
}

int[] array = CreateArray(5, 0, 100);
PrintArray(array);
PrintArray(CopyArray(array));