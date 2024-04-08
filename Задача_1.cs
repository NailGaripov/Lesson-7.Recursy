// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.


Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

static void OutputNaturalNumbersMN(int number, int N)
{
    if (number <= N)
    {
        Console.Write(number + " ");
        OutputNaturalNumbersMN(number + 1, N);
    }
}
OutputNaturalNumbersMN(M, N);