int[] Random(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(min, max);
    Console.WriteLine("Базовый массив: " + String.Join(" ", arr));
    return arr;
}

int[] Method(int[] arr, int[] arrB)
{
    Console.WriteLine("Четные элементы массива: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arrB[i] += arr[i];
            Console.Write(arrB[i] + " ");
        }
    }
    return (arrB);
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] Array1 = new int[length];
int[] Array2 = new int[Array1.Length];
Random(Array1, 0, 100);
Method(Array1, Array2);