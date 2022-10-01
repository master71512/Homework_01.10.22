// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
double[] new_arr(int k)
{
    double[] a = new double[k];
    for (int i = 0; i < k; i++)
    {
        a[i] = Convert.ToDouble(new Random().Next(1, 1000) / 10.0);
        Console.Write(a[i] + " ");
    }
    Console.WriteLine();
    return a;
}

double[] a = new_arr(10);
double max = a[0];
for (int i = 1; i < 10; i++)
{
    if (a[i] > max) max = a[i];
}
double min = a[0];
for (int i = 1; i < 10; i++)
{
    if (a[i] < min) min = a[i];
}
Console.WriteLine(max - min);