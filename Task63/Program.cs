// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("N");
int N = int.Parse(Console.ReadLine()!);

string Gap(int M)
{
    string res =String.Empty;
    for (int i = 1; i <= M; i++)
    {
        res+=i;
    }
    return res;
}

string Rec(int N)
{
    if(N<1) return String.Empty;
    else return Rec(N-1)+N;
}

Console.WriteLine($"{Gap(N)} ");
Console.WriteLine($"{Rec(N)} ");