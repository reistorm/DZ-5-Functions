//Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.
//[3 7 22 2 78] -> 76


double[] initArray()
{
    Console.WriteLine("Введите число элементов массива: ");
    int N = int.Parse(Console.ReadLine());
    double[] arr = new double[N];
    Random rnd = new Random();
    Console.Write("Массив: ");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {

        arr[i] = rnd.NextDouble() * 100;

        Console.Write(Math.Round(arr[i], 3, MidpointRounding.AwayFromZero ));
        Console.Write(", ");
    }
    int Length = arr.Length;
    arr[arr.Length - 1] = rnd.NextDouble() * 100;
    Console.Write(Math.Round(arr[arr.Length - 1], 3, MidpointRounding.AwayFromZero));
    Console.Write("]");
    Console.WriteLine();
    return arr;
}
double[] arr = initArray();

int index = 0;
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > arr[index])
    {
        index = i;
    }

}
Console.Write("Максимальное число = ");
Console.WriteLine(Math.Round(arr[index], 3, MidpointRounding.AwayFromZero));

int ind = 0;
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < arr[ind])
    {
        ind = i;
    }
}

Console.Write("Минимальное число = ");
Console.WriteLine(Math.Round(arr[ind], 3, MidpointRounding.AwayFromZero));

double result =  arr[index] - arr[ind];
Console.Write("Разница между макс и мин элементами в массиве = ");
Console.Write(Math.Round(result, 3, MidpointRounding.AwayFromZero));
Console.WriteLine();


