// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// EXAMPLE:     M = 1; N = 5 -> "2, 4"
//              M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void RecursionPrintEven(int arg1, int arg2)
{
    if (arg1 > arg2)  // Condition of exit
    {
        return;
    }
    
    if (arg1 % 2 == 0)  //If the number can be devided and the reminder is 0, then it's an even number that we will print
    {
        Console.WriteLine(arg1);
    }
    
    RecursionPrintEven(arg1 + 1, arg2);
}

int number1 = ReadInt("Enter a number 1: ");
int number2 = ReadInt("Enter a number 2: ");
RecursionPrintEven(number1, number2);
