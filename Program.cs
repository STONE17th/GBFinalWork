void PrintArray (string [] array) //Метод для выводы массивов в консоль
{
    foreach (string Element in array)
        Console.Write($"{Element}, ");
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите массив строк, разделяя элементы запятой: ");
string DefaultData = Console.ReadLine() ?? "0"; //Ввод исходного массива одной строкой

string [] DefaultArray = DefaultData.Split(","); //Разделение строки на исходный массив через запятую

int counter = 0; //Создание переменной для подсчета размера нового массива
int i = 0; //Создание переменной-счетчика для заполнения нового массива

foreach (string Element in DefaultArray) //Цикл для подсчета значения переменной counter
    if (Element.Length <= 3)
        counter++;

string [] NewArray = new string [counter]; //Создание нового массива заданного размера

foreach (string Element in DefaultArray) //Заполнение нового массива элементами из трех и меньше символов из исходного массива
    if (Element.Length <= 3)
    {
        NewArray[i] = Element;
        i++;
    }

PrintArray(DefaultArray); //Вывод в консоль исходного массива для наглядного сравнения работы программы
PrintArray(NewArray); //Вывод в косноль нового массива как результат работы программы