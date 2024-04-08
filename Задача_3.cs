// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.


int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("Развернутый массив: ");
ReversArray(array, array.Length - 1);

static void ReversArray(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        ReversArray(array, index - 1);
    }
}