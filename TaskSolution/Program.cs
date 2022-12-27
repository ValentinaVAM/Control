
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] str = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку №{0}: ", i + 1);
    str[i] = Console.ReadLine();
}
Console.WriteLine("Вы ввели массив из строк:");
Console.Write("[");
for (int i = 0; i < n; i++)
{
    if (i < n - 1) Console.Write($"{str[i]}, ");
    else Console.Write($"{str[i]}");
}
Console.WriteLine("]");

string[] newArray = new string[str.Length];
void NewArrayStrings(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            newArray[count] = str[i];
            count++;
        }
    }
}
void PrintArray(string[] newArray)
{
    Console.Write("[");
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i < newArray.Length - 3) Console.Write($"{newArray[i]}, ");
        else Console.Write($"{newArray[i]}");
    }
    Console.WriteLine("]");
}
NewArrayStrings(str);
Console.WriteLine("Массив из строк, длина которых <= 3 символам:");
PrintArray(newArray);