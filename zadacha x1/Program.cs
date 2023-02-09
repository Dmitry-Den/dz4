// Подсчитать сумму цифр в числе
Console.Clear();
Console.WriteLine("Введите целое число a ");
int a = int.Parse(Console.ReadLine()!);
int sum = 0;
a = Math.Abs(a);
while (a > 0)
{
    sum += a % 10;
    a = a / 10;
}
Console.WriteLine(sum);