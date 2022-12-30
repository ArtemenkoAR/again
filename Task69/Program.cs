// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 


Console.WriteLine("A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("B");
int B = int.Parse(Console.ReadLine()!);

// double Pow(double M, int N)
// {
//     if(N<0) M = 1/Math.Pow(M,N)/10;
//     else M = Math.Pow(M,N);
//     return M;
// }

double Rec(double M, int N)
{
    if(N==0) return 1;
    // if (N<0) return (1/M)/10 * 1/Rec(M, N+1);
    else return M*Rec(M, N-1);
}

// Console.WriteLine(Pow(A,B));
Console.WriteLine(Rec(A,B));