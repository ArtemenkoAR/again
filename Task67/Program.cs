// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("M");
int M = int.Parse(Console.ReadLine()!);

int Sum(int A)
{
    int sum = 0;
    while(A!=0)
    {
        sum+=A%10;
        A=A/10;
    }
    return sum;
}

int Rec(int A)
{
    if(A==0) return 0;
    else return A%10 + Rec(A/10);
}



Console.WriteLine(Sum(M));
Console.WriteLine(Rec(M));
