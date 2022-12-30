// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("N");
int N = int.Parse(Console.ReadLine()!);

string Natural(int A, int B)
{
    string res = String.Empty;
    while (A < 1)
    {
        A++;
    }
    for (int i = A; i <= B; i++)
    {
        res += i;
    }
    return res;
}

string Rec(int A,int B)
{
     while (A < 1) A++;
     if (A<=B) return A + Rec(A+1, B);
     else return String.Empty;
}

Console.WriteLine(Natural(M, N));
Console.WriteLine(Rec(M, N));

