// Вывести все натуральные числа в промежутке от M до N


void Print(int a, int b)
{
    if (a > b) return;
    Console.Write(a + " ");
    Print(a+1, b);
}

int M = 4;
int N = 9;

Print(M,N);