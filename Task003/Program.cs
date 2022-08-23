// Перевести десятичное число в двоичное.

int FindArrayLength(int number)
{
    int length = 0;
    while (number >= 1)
    {
        number = number / 2;
        length++;
    }
    return length;
}

int[] ConvertToBinary(int number)
{
    int[] array = new int[FindArrayLength(number)];
    for (int i = 0; i < array.Length; i++)
    {
        array[array.Length - 1 - i] = number % 2;
        number = number / 2;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] array = ConvertToBinary(8);
PrintArray(array);