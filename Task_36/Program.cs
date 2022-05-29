//Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] InitArray()
{
    Console.WriteLine("Введите число элементов массива:");
    int N = int.Parse(Console.ReadLine());
    int[] arr = new int[N];
    var rnd = new Random();
    Console.Write("Массив: ");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arr[i] = rnd.Next(-100, 100);
        Console.Write(arr[i] + ", ");
    }
    int Length = arr.Length;
    arr[arr.Length - 1] = rnd.Next(-100, 100);
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
    Console.WriteLine();
    return arr;
}

int[] arr = InitArray();
int sum = 0;
for (int i = 1; i < arr.Length; i++)
{
    sum = sum + arr[i];
    i++;
    
}
Console.WriteLine($"Сумма нечетных чисел {sum}");

