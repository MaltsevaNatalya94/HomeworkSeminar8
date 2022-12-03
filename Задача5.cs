// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int n = 4;
int[,] array = new int[n, n];

int currentCount = 1;
int i = 0;
int j = 0;

while (currentCount <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = currentCount;
  currentCount++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else 
    if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
  else 
    if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
  else
    i--;
}


for (int a = 0; a < array.GetLength(0); a++)
{
    for (int b = 0; b < array.GetLength(1); b++)
    {
        if (array[a,b] / 10 <= 0)
        Console.Write($" {array[a,b]:d2} ");

        else Console.Write($" {array[a,b]:d2} ");
    }
    Console.WriteLine();
}
