// 10. Программа принимающая на входе число N и выдающая таблицу кубов чисел от 1 до N.

Console.WriteLine(" Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<=N+1; i++)
{
    i = (i * i * i);
    Console.Write($" {i} ");
}
Console.WriteLine($" : таблица кубов от 1 до {N}.");
