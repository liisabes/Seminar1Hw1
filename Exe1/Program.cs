//Задача 1: Напишите программу, которая на вход принимает два числа
//и выдаёт, какое число большее, а какое меньшее.

int firstNumber = -9;
int secondNumber = -3;
int max;
max = firstNumber;

if (firstNumber > secondNumber)
{
    Console.WriteLine("Первое число: " + firstNumber + " больше второго " + secondNumber);
}
else
{
    Console.WriteLine("Второе число: " + secondNumber + " больше первого " + firstNumber);
}

