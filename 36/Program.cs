// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] new_arr (int k)
{
    int[] a = new int [k];
    for (int i = 0; i < k; i++)
    {
        a[i] = new Random().Next(1, 100);
        Console.Write(a[i]+ " ");
    }
    Console.WriteLine();
    return a;
}
int s = 0;
int[] a = new_arr(10);
for (int i = 1; i < 10; i+=2)
{
    s += a[i];    
}
Console.WriteLine(s);