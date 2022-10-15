/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();

int A = EnterNumber("Введите целое число А: ", "Ошибка ввода");
int B = EnterNumber("Введите целое число B: ", "Ошибка ввода");
double exp_A = PerformExponentiation(A, B);
Console.Write($"{A}, {B} -> {exp_A}");

//-----------------------------------
//Функция позволяет ввести исходные данные с клавиатуры
static int EnterNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect)
            return num;
        Console.WriteLine(errorMessage);
    }
}
//-----------------------------------
//Функция возводит А в степень B
static double PerformExponentiation(int A, int B)
{
    double exp_A = 1;

    for (int i = 1; i <= Math.Abs(B); i++)	// Возводим число А в степень В
        exp_A *= A;

    if (B > 0)
        return exp_A;
    else
    {
        exp_A = 1 / exp_A;  // Вычисляем результат в случае отрицательного значения степени (В)
        return exp_A;
    }
}