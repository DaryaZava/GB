// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void MetFib(int Num)
{
int[] ListFib = new int[Num];
Console.Write(ListFib[0]);
ListFib[1] = 1; Console.Write(ListFib[1]);
for (int i = 2; i < Num; i++)
{
    ListFib[i] = ListFib[i-1]+ListFib[i-2];
    Console.Write(ListFib[i]);
}
}
int num = int.Parse(Console.ReadLine()!);
MetFib(num);
