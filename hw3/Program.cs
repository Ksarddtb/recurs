// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintArrayReverse(int[] arr, int index)
{
    if (index < 0) return;
    Console.WriteLine(arr[index]);
    PrintArrayReverse(arr, index - 1);
}

int[] array = { 1, 2, 3, 4, 5 };

Console.WriteLine("Элементы массива, начиная с конца:");
PrintArrayReverse(array, array.Length - 1);