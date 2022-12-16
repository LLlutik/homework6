// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
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

bool doYouWantAnyMore = true;
int count = 0;
while(doYouWantAnyMore)
{
    int enterNumber = GetNumber("Введите число:");
    if(enterNumber > 0 ) count++;

    System.Console.Write("Хотите еще ввести? y(yes) / n(no):");
    string answer = Console.ReadLine();
    if(answer == "n") doYouWantAnyMore = false;
}
System.Console.WriteLine($"Из всех введенных чисел положительными было {count} штук.");