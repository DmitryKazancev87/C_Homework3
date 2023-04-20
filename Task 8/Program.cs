// 8. Программа определяющая является ли пятизначное число палиндромом или нет.

Console.WriteLine("Введите пятизначное число :");
string N = Console.ReadLine();
int Len = N.Length;
    if (Len==5)
    {
        if (N[0]==N[4] && N[1]==N[3])
        {
            System.Console.WriteLine($:"{N} - полиндром");
        }     
        else {
            System.Console.WriteLine($:"{N} - не полиндром");
        }
    }
    else
    {
        System.Console.WriteLine($ "Ошибка : {N} - введено не пятезначное число");
    }