// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckInput(int number)
{
    if (number<=0) Console.WriteLine("Число не является натуральным. Пожалуйста, повторите попытку."); 
}

int SumNaturalNumbers(int m, int n)
{
if (m<=0 || n<=0 || m>n)
return 0;
else if (m==n)
return n;
else return m + SumNaturalNumbers(m + 1, n);
}

int M = Input("Введите число M: ");
int N = Input("Введите число N: ");
CheckInput(M);
CheckInput(N);
Console.Write(SumNaturalNumbers(M,N));