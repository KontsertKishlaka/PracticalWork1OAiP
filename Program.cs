namespace PracticalWork1OAiP;

public class Program
{
    private static double _side, _diagonal, _area; // Блок переменных для вычисления стороны и площади треугольника
    private static double _number1, _number2; // Блок переменных для вычисления суммы двух чисел

    private const double PI = 3.14; // Блок переменных для вычисления площади круга
    private static double _radius;

    private static double _celsiusDegrees; // Блок переменных для вычисления температуры

    private static double _productPrice; // Блок переменных для вычисления скидки
    private static double _salePercent;

    public static void Main(string[] args)
    {
        // Блок вычисления стороны и площади треугольника
        Console.WriteLine("Введите площадь квадрата S: ");
        _area = Convert.ToDouble(Console.ReadLine());

        _side = Math.Round(Math.Sqrt(_area), 2);
        _diagonal = Math.Round((Math.Sqrt(2) * _side), 2);

        Console.WriteLine($"Сторона квадрата равна: {_side}");
        Console.WriteLine($"Диагональ квадрата равна: {_diagonal}\n");



        // Блок вычисления суммы двух чисел
        Console.WriteLine($"Введите 1-ое число: ");
        _number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Введите 2-ое число: ");
        _number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Сумма двух чисел равна: {CalculateSum(_number1, _number2)}\n");



        // Блок вычисления площади круга
        Console.WriteLine($"Введите радиус круга: ");
        _radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Площадь круга равна: {CalculateCircleArea(Math.Round(_radius, 2))}\n");



        // Блок вычисления температуры
        Console.WriteLine($"Введите температура в градусах Цельсия: ");
        _celsiusDegrees = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Температура в Фаренгейтах равна: {Math.Round(CalculateFahrenheitDegrees(_celsiusDegrees), 2)}\n");



        // Блок вычисления скидки
        Console.WriteLine($"Введите стоимость товара: ");
        _productPrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Введите процент скидки: ");
        _salePercent = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Сумма скидки: {CalculateSale(_productPrice, _salePercent)}\n" +
            $"Итоговая сумма: {CalculateFinalePrice(_productPrice, _salePercent)}\n");
    }

    private static double CalculateSum(double number1, double number2) => number1 + number2;

    private static double CalculateCircleArea(double radius) => Math.Round(PI * Math.Pow(radius, 2), 2); // Можно использовать Math.PI

    private static double CalculateFahrenheitDegrees(double celsiusDegrees) => celsiusDegrees * (9f/5f) + 32;

    private static double CalculateSale(double productPrice, double salePercent) => productPrice * (salePercent / 100);

    private static double CalculateFinalePrice(double productPrice, double salePercent) => productPrice - (productPrice * (salePercent / 100));
}