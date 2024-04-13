//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

static int PrintAckermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return PrintAckermann(m - 1, 1);
    else
        return PrintAckermann(m - 1, PrintAckermann(m, n - 1));
}

Console.WriteLine("Введите Начальное число");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int n=Convert.ToInt32(Console.ReadLine());

int result=PrintAckermann(m, n);
 Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");