/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int n = 10;
double[] array = new double[n];
double result = 0;
double min = 0;
double max = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-10, 10);
    if (array[i] > max)
        max = array[i];
    if (array[i] < min)
        min = array[i];
    result = max - min;
}
Console.WriteLine("[" + string.Join(", ", array) + "] -> " + result);


/* Второе решение задачи. Выполнял его через справку майкрософт. 
Поэтому некоторые моменты до конца не понял и хотел бы их обсудить на занятии, к примеру.
или в личку в телеграмм. 

int n = 10;
double[] array = new double[n];
Random rand = new Random();
double result = 0;
double min = 0;
double max = 0;
for (int i = 0; i < n; i++)
{
    array[i] = rand.Next(-10, 10) + rand.NextDouble();
    if (array[i] > max)
        max = array[i];
    if (array[i] < min)
        min = array[i];
    result = max - min;
    Console.Write("{0,8:N2}", array[i]);
}
Console.WriteLine();
Console.WriteLine("{0,8:N2}", result);
*/