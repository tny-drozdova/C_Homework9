// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// EXAMPLE:     M = 1; N = 15 -> 120
//              M = 4; N = 8 -> 30

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int RecursiveSum(int arg1, int arg2)
{
    if (arg1 > arg2)   // The condition of exit is when arg1 is larger than arg2, then we return the sum as 0
    {
        return 0;
    }

    return arg1 + RecursiveSum(arg1 + 1, arg2);  //we canlculate the sum of the numbers in our range
}

int number1 = ReadInt("Enter number 1: ");
int number2 = ReadInt("Enter number 2: ");

int sum = RecursiveSum(number1, number2);
Console.WriteLine("Sum of numbers: " + sum);
