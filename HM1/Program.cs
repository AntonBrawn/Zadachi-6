// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

using System;
using static System.Console;
Clear();
{

WriteLine("Введите цифры через пробел");
int[] myArray = GetArrayFromString(ReadLine());
WriteLine($"Количество положительных элементов: {PositiveNumbersCount(myArray)}");
int[] GetArrayFromString(string message)
{
    string[] numbers = message.Split();
    int[] result= new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}

int PositiveNumbersCount (int[] array)
{
    int count = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if(array[k] > 0) count = count+1;
    }
    return count;

}

}
