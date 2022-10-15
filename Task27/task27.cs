/*Программа принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

int N = EnterNumber("Введите целое число N: ", "Ошибка ввода");
SummOfNumber(N);
	
//-----------------------------------
//Функция позволяет ввести исходные данные с клавиатуры
static int EnterNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int N);
        if (isCorrect)
            return N;
        Console.WriteLine(errorMessage);
    }
}
//Функция подсчитывает сумму цифр переданного числа
static void SummOfNumber(int N)
{
	int sum = 0;
	int tempN = Math.Abs(N);
	for(; tempN >= 1;)		// Считаем сумму цифр
	{
		int modulo = tempN % 10;
		tempN = tempN/10;
		sum += modulo;
	}
	Console.WriteLine($"{N} -> {sum}");
}
//----------------------------------