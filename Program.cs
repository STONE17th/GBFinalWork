Console.Clear();
Console.Write("Введите массив строк, разделяя элементы запятой: ");
string DefaultData = Console.ReadLine() ?? "0";

string [] DefaultArray = DefaultData.Split(",");

int counter = 0;
int i = 0;

foreach (string Element in DefaultArray)
    if (Element.Length <= 3)
        counter++;

string [] NewArray = new string [counter];

foreach (string Element in DefaultArray)
    if (Element.Length <= 3)
    {
        NewArray[i] = Element;
        i++;
    }