// Написать программу вычисления произведения чисел от 1 до N
Console.Clear();
Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine()!);
int N1 = 1;
int count = 1;
while (N1 <= N)
{
    count = (N1 * count);
    N1++;
}
Console.Write($"{count} ");