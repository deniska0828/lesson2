int n = 10;
int[] array = { 2, 5, 4, 6, 7, 8, 12, 45, 4, 12 };
int i =0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}