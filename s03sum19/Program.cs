/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
int number = InitNumberByUser();
int interim = number;

static int InitNumberByUser()
{
    try
    {
        Console.Write("Введите пятизначное число: ");
        return int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

static int DefineNumeral(ref int interim)
{
    int numeral = interim % 10;
    interim = interim / 10;
    return numeral;
}

if (9999 < number && number < 100000)
{
    int numeral5 = DefineNumeral(ref interim);
    int numeral4 = DefineNumeral(ref interim);
    int numeral3 = DefineNumeral(ref interim);
    int numeral2 = DefineNumeral(ref interim);
    int numeral1 = DefineNumeral(ref interim);
    if (numeral1 == numeral5 && numeral2 == numeral4)
        Console.WriteLine($"{number} -> да");
    else
        Console.WriteLine($"{number} -> нет");
}
else
    Console.WriteLine($"{number} - не пятизначное число");