int[] Array(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 99);
        Console.Write($"{result[i]} ");
    }
    return result;
}
int[] array = Array(6, 1, 99);
Console.WriteLine();
int sum = 0;
for (int i=0; i<array.Length; i++){
    if (array[i]%2 != 0){
        sum = sum + array[i];
    }
}
Console.WriteLine(sum);