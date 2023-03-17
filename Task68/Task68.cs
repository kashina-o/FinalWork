// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckInput(int number)
{
    if (number<0) Console.WriteLine("Число отрицательное. Пожалуйста, повторите попытку."); 
}

int AckermannFunction (int m, int n)
{
if (m == 0) return n + 1;
if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
return AckermannFunction(m, n);
}

int m = Input("Введите неотрицательное число m: ");
int n = Input("Введите неотрицательное число n: ");
CheckInput(m);
CheckInput(n);
Console.WriteLine($"A(m,n) = {AckermannFunction(m, n)}");