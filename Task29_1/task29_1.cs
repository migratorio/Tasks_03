/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

int[] array = EnterArray();

PrintArray(array);

int[] EnterArray()
{
    int[] tempArr = new int[1];
    for(int i = 0; ; i++)
    {
    Console.Write($"Введите {i}-й элемент массива: ");
	string y = Console.ReadLine() ?? "";
	if(y == "q")
	    break;
    Array.Resize(ref tempArr, i + 1);
	tempArr[i] = int.Parse(y);
    }
    return tempArr;
}
static void PrintArray(int[] array) => Console.WriteLine($"{String.Join(", ",array)}  -> [{String.Join(", ",array)}]");    