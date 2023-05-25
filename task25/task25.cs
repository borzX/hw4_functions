// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А:");
int num_a = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int num_b = System.Convert.ToInt32(Console.ReadLine());

double Num_a()
{
    double result = 0;
    int count = 0;
    while (count != 1)
    {
       result = Math.Pow(num_a, num_b);
       count = count + 1;
    }
    return result;
}

double res = Num_a();
Console.WriteLine(res);
