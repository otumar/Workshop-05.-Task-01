// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] InitArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
void PrintArray(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        System.Console.Write($"{arrA[i]} ");
    }
    System.Console.WriteLine();
}

int SearchEvenElements(int[] arrA)
{
    int sum = 0;
    for(int i = 0; i < arrA.Length; i++)
    {
        if (arrA[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}
int[] myArray = InitArray(10, 100, 1000);
PrintArray(myArray);
int sum = SearchEvenElements(myArray);
System.Console.WriteLine($"Количество четных чисел в масиве = {sum}");