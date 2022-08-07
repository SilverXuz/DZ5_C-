/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int n = 20;
int[] array_first = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    array_first[i] = new Random().Next(100, 999);
    if (array_first[i] % 2 == 0)
        count++;
    
}
Console.WriteLine("[" + string.Join(", ", array_first) + "] четных -> " + count);
