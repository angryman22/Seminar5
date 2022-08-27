// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[12];
// int arraySize = array.Length;
// int resPos = 0;
// int resNeg = 0;
// for (int i = 0; i < arraySize; i++)
// {
//     array[i] = new Random().Next(-9, 10);
// }
// for (int j = 0; j < arraySize; j++)
// {
//     if (array[j] < 0) resNeg = resNeg + array[j];
//     else resPos = resPos + array[j];
// }
// Console.WriteLine($"[{string.Join(",", array)}]");
// Console.WriteLine("Сумма положительных членов массива равна" + resPos );
// Console.WriteLine("Сумма отрицательных членов массива равна" + resNeg );


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] array = new int[4];
// int arraySize = array.Length;
// for (int i = 0; i < arraySize; i++)
// {
//     array[i] = new Random().Next(-9, 10);
// }
// Console.WriteLine($"[{string.Join(",", array)}]");
// for (int j = 0; j < arraySize; j++)
// {
//     array[j] = array[j]*-1;
// }
// Console.WriteLine($"[{string.Join(",", array)}]");

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// Console.WriteLine("Введите число для поиска в массиве");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[20];
// int arraySize = array.Length;
// for (int i = 0; i < arraySize; i++)
// {
//     array[i] = new Random().Next(-9, 10);
// }
// Console.WriteLine($"[{string.Join(",", array)}]");
// bool find = false;
// for (int j = 0; j < arraySize; j++)
// {
//     if (array[j] == number)
//     {
//         find = true;
//         break;
//     }
// }
// if (find) Console.WriteLine("Искомое число присутствует в массиве");
// else Console.WriteLine("Искомое число не присутствует в массиве");


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[123];
// int arraySize = array.Length;
// int[] randMAss(int[] myArray)
// {
//     int arraySize = myArray.Length;
//     for (int i = 0; i < arraySize; i++)
//     {
//         myArray[i] = new Random().Next(124);
//     }
//     return myArray;
// }

// Console.WriteLine($"[{string.Join(",", randMAss(array))}]");
// int elemNumb = 0;
// for (int j = 0; j < arraySize; j++)
// {
//     if (array[j] >= 10 && array[j] <= 99 ) elemNumb++;
// }
// Console.WriteLine("Количество искомых элементов в массиве равно " + elemNumb);

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];
int arraySize = array.Length;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine($"[{string.Join(",", array)}]");
int count = 0;
for (int j = 0; j < arraySize; j++)
{
    if (array[j]%2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Количество четных чисел в массиве равно " + count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
int arraySize = array.Length;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(20);
}
Console.WriteLine($"[{string.Join(",", array)}]");
int summ = 0;
for (int j = 1; j < arraySize; j+=2)
{
    summ += array[j];
}
Console.WriteLine("Сумма чисел в массиве на нечетных позициях равна " + summ);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[10];
int arraySize = array.Length;

for (int i = 0; i < arraySize; i++)
{
    array[i] = (new Random().NextDouble())*100;
}
Console.WriteLine($"[{string.Join(",", array)}]");
double max = array[0];
double min = array[0];
for (int j = 0; j < arraySize; j++)
{
    if (array[j] > max) max = array[j];
    else if (array[j] < min) min = array[j];
}
double diff = max - min;
Console.WriteLine("Разница между максимальным и минимальным членом массива равна " + diff);