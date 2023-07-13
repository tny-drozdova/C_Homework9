// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Функция Аккермана обозначается A(m,n), принимает два неотрицательных целых числа в качестве параметров и возвращает натуральное число. 
// Function that is used to test the limitations of computing algorithms. 
// It is defined as     A(m,n) = n+1 if m=0, 
//                      A(m-1,1) if m>0 and n=0, and
//                      A(m-1,A(m,n-1)) if m>0 and n>0.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackermann(int m, int n)
{
    if (m == 0)   //If m is 0, the base case is reached, and the function executes (n + 1).
    {
        return n + 1;
    }
    else if (n == 0)  // If n is 0, the function executes (m - 1, 1).
    {
        return Ackermann(m - 1, 1);
    }
    else    //If neither m nor n is 0, the function executes (m - 1, Ackermann(m, n - 1)).
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));  
    }
}

int number1 = ReadInt("Enter the value for 'm': ");
int number2 = ReadInt("Enter the value for 'n': ");

int result = Ackermann(number1, number2);
Console.WriteLine("Ackermann(" + number1 + ", " + number2 + ") = " + result);