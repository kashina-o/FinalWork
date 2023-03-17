//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckInput(int number)
{
    if (number<=0) Console.WriteLine("Число не является натуральным. Пожалуйста, повторите попытку."); 
}

void NaturalNumbers(int number)
{
    if (number > 0)
    {
        Console.Write("{0} ", number);
        NaturalNumbers(number - 1);
    }
}

int N = Input("Введите число N: ");
CheckInput(N);
NaturalNumbers(N);