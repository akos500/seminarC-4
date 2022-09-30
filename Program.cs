
/*
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B. Решить задачу 
с использованием методов.
*/

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
toDegree(numberA, numberB);

static void toDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i = i + 1)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
