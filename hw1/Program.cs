// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintNaturalNumber(int min,int max){
    if(min==max) return;
    PrintNaturalNumber(min,max-1);
    Console.WriteLine($"{max} ");
}
Console.WriteLine("Введите Начальное число");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int max=Convert.ToInt32(Console.ReadLine());

PrintNaturalNumber(min,max);