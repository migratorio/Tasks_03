/* Программа выводит в консоль задаваемый пользователем массив натуральных чисел произвольной длины, .
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

int[] array = EnterArray();
PrintArray(array);

//------------------------------------------
int[] EnterArray()	// Функция формирует пользовательский массив
{
    int[] tempArr = new int[1];
    for(int i = 0; ; i++)	// Бесконечный цикл. прерываемый пользователем
    {
    Console.Write($"Введите {i}-й элемент массива: ");
	string y = Console.ReadLine() ?? "";
	if(y == "q")	// прерываем ввод элементов массива по нажатию "q"
	    break;
    Array.Resize(ref tempArr, i + 1);	//Меняем размер массива по мере увеличения его элементов
	tempArr[i] = int.Parse(y);
    }
    return tempArr;
}
//------------------------------------------
// Функция выводит массив в консоль 
static void PrintArray(int[] array) => Console.WriteLine($"{String.Join(", ",array)}  -> [{String.Join(", ",array)}]");    