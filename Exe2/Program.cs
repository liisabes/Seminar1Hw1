//Задача 2: Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.
int firstNumber = 22;
int secondNumber = 3;
int thirdNumber = 9;
int max;

max = firstNumber;

if (secondNumber > firstNumber)
{
     max = secondNumber;
}
if (thirdNumber > secondNumber)
{
        max = thirdNumber;
}
if (firstNumber > thirdNumber)
{
    max = firstNumber;
}
Console.WriteLine("Максимальное число: " + max);

