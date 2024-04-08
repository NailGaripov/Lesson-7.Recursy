// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = FuncAkkerman(m, n);
Console.WriteLine($"Значение функции Аккермана для неотрицательных натуральных чисел ({m}), ({n}) = {res}");

int FuncAkkerman(int m, int n)
{
    if (m == 0)
    return n + 1;
    else if (n == 0)
    return FuncAkkerman(m - 1, 1);
    else
    return FuncAkkerman(m-1, FuncAkkerman(m, n - 1));
}