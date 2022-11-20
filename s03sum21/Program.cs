/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();
static void InitCoordinatesByUser(ref double X, ref double Y, ref double Z)
{
    try
    {
        Console.Write("Введите X: ");
        X = double.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите Y: ");
        Y = double.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите Z: ");
        Z = double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка ввода! {ex.Message}");
        return;
    }
}

double X = 0, Y = 0, Z = 0;

InitCoordinatesByUser(ref X, ref Y, ref Z);
double X1 = X;
double Y1 = Y;
double Z1 = Z;

InitCoordinatesByUser(ref X, ref Y, ref Z);
double X2 = X;
double Y2 = Y;
double Z2 = Z;

double distance;
distance = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1), 2) + Math.Pow((Z2-Z1), 2));

Console.WriteLine($"A({X1}, {Y1}, {Z1}); B({X2}, {Y2}, {Z2}) -> {distance}");