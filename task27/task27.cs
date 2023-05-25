// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = System.Convert.ToInt32(Console.ReadLine());

int Sum_numbers(int number)
{
    string num_string = System.Convert.ToString(number);
    int num_lenght = num_string.Length;
    int sum = 0;
    char[] arr = new char[num_lenght];
    for (int i = 0; i < num_lenght; i++)
    {
        arr[i] = num_string[i];
        int array_i_value = (int)Char.GetNumericValue(arr[i]);
        sum = array_i_value + sum;
    }
    return sum;
}

int result = Sum_numbers(number);
Console.WriteLine($"Сумма цифр в числе {number} равна: {result}");