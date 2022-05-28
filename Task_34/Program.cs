//Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
//[345, 897, 568, 234] -> 2

int[] initArray()
{
    Console.WriteLine("Введите число элементов массива: ");
    int N = int.Parse(Console.ReadLine());
    int[] arr = new int[N];
    var rand = new Random();
    Console.Write("Массив: ");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arr[i] = rand.Next(100, 1000);
        Console.Write(arr[i] + ", ");
    }
    int Length = arr.Length;
    arr[arr.Length - 1] = rand.Next(100, 1000);
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
    Console.WriteLine();
    return arr;
}


int[] arr = initArray();
int EvenNum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        EvenNum++;
    }
}
Console.Write($"Число четных чисел в массиве: {EvenNum} ");
Console.WriteLine();

