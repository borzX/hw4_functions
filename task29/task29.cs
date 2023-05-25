// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]


int[] ArrayRandom()
{
    int[] array = new int[8];
    Random numRandom = new Random();
    for (int i =0; i < array.Length; i++)
    {
        array[i] =  numRandom.Next(1, 100);
    }
    return array;
}

int[] res = ArrayRandom();
Console.WriteLine(String.Join(",", res));




