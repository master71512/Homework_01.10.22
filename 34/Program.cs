
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int[] new_arr (int k)
{
    int[] a = new int [k];
    for (int i = 0; i < k; i++)
    {
        a[i] = new Random().Next(1, 1000);
        Console.Write(a[i]+ " ");
    }
    Console.WriteLine();
    return a;
}
int k = 0;
int[] a = new_arr(10);
for (int i = 0; i < 10; i++)
{
    if (a[i] % 2 == 0) k++;    
}
Console.WriteLine(k);