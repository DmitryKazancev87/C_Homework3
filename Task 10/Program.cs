// 10. Программа принимающая на входе число N и выдающая таблицу кубов чисел от 1 до N.

Console.WriteLine(" Введите число N : ");
int Number = int.Parse(Console.ReadLine());
for (int i = 1; i <= Number; i++)
{   
    Console.Write($"{i*i*i}  ");
}
Console.WriteLine($" : таблица кубов от 1 до {Number}.");


// Ввод через фунцию EnterInformation:

//int EnterInfomation (string message)
//{
//    Console.Write (message);
//    return int.Parse (Console.ReadLine());
//}
//int Number = EnterInfomation(" Введите число N : ");
//for (int i = 1; i <= Number; i++)
//{
//       Console.Write($"{i*i*i}  ");}