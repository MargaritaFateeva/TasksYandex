// Опишите словами алгоритм решения задачи
// Ввод: натуральное число n
// Вывод: количество простых чисел строго меньше n
// Решение должно быть вычислительно-эффективным

Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine());

while (n < 1)// проверка ввода данных
{
    Console.WriteLine("!Ошибка, не является натуральным числом, введите новое значение");
    Console.Write("Введите натуральное число N: ");
    n = int.Parse(Console.ReadLine());
}
int count = 0;
for (int i=1; i<n; i++)
{
    if (i<n) count++;
    else count=count;
}
Console.WriteLine($"Количество простых чисел строго меньше n = {count}");