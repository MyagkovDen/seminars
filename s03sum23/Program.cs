/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
static int InitNumberByUser()
{
    try
    {
        Console.Write("Введите число (N): ");
        return int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

double number = InitNumberByUser();
Console.Write($"{number} -> ");

double interim = 1;
while (interim <= number)
{
    double result = Math.Pow(interim, 3);
    Console.Write($"{result}, ");
    interim++;
}