// Задание: Написать программу, которая из имеющегося массива строк,
// формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2",":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();

string userText = Console.ReadLine();
int size = 1, count = default;

for (int i = 0; i < userText.Length; i++)
{
    if (userText[i] == ' ')
    {
        size++;
    }
}

string[] textArray = new string[size];
for (int i = 0; i < userText.Length; i++)
{
    if (userText[i] != ' ')
    {
        textArray[count] += userText[i];
    }
    else count++;
}

Console.Write("\n[");
for (int i = 0; i < textArray.Length; i++)
{
    if (i < textArray.Length - 1) Console.Write($"\"{textArray[i]}\",");
    else Console.Write($"\"{textArray[i]}\"");
}
Console.Write("]");

count = default;
Console.Write("[");
for (int i = 0; i < textArray.Length; i++)
{
    if (textArray[i].Length < 4)
    {
        count++;
        Console.Write($"\"{textArray[i]}\",");
    }
}
Console.WriteLine("]");