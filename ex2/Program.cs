// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumber(string message)
{
    bool isCorrect = false;
    double result = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        if(double.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число! Попробуйте еще раз:");
        }
    }
    return result;
}

(double, double) GetPoint(double k1, double k2, double b1, double b2){
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    return (x, y);
}
double k1 = GetNumber("Введите коэффициент k1: ");
double k2 = GetNumber("Введите коэффициент k2: ");
double b1 = GetNumber("Введите коэффициент b1: ");
double b2 = GetNumber("Введите коэффициент b2: ");
(double x, double y) = GetPoint(k1, k2, b1, b2);
System.Console.WriteLine($"Точка пересечения ({x}, {y})");