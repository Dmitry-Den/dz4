// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();

int count = 1;
Console.Write("введте положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
while (count <= N)
{
    int kub = Convert.ToInt32(Math.Pow(count, 3));
    if ((count % 2) == 0)
    {
    Console.WriteLine (kub);
    }
    count++;
}