Console.WriteLine("Введите текст : ");

string? receivedString = Console.ReadLine();
if (receivedString == null)
{
    Console.WriteLine("Строка пуста.");
    Environment.Exit(0);
}
Console.WriteLine("Выбирите действие : " +
    "\n 1 - Чтоб найти слова, содержащие максимальное количество цифр " +
    "\n 2 - Найти самое длинное слово и определить, сколько раз оно встретилось в тексте " +
    "\n 3 - Заменить цифры  на слова  ");

int useChage = Convert.ToInt32(Console.ReadLine());
switch (useChage)
{
    case 1:
        {
            MaxNumber(receivedString);
            break;
        }
    case 2:
        {
            LengthWord(receivedString);
            break;
        }
    case 3:
        {
            ReplacingNumbers(receivedString);
            break;
        }
}
static void MaxNumber(string receivedString)
{
    string[] str = receivedString.Split(" ");
    int maxDigits = 0;
    int index = 0;
    for (int i = 0; i < str.Length; i++)
    {
        int CounterMemory = 0;
        for (int j = 0; j < str[i].Length; j++)
        {
            if (char.IsNumber(str[i][j]))
            {
                CounterMemory++;
            }
            if (CounterMemory > maxDigits)
            {
                maxDigits = CounterMemory;
                index = i;
            }
        }
    }
    if (maxDigits > 0)
        Console.WriteLine("Больше всего цифр в слове " + str[index]);
    else
    {
        Console.WriteLine("в словах нет цифр");
    }
}
static void LengthWord(string receivedString)
{
    string[] str = receivedString.Split(" ");
    string lengthWord = " ";
    int repetitionCounter = 0;
    int repetition = 0;
    int a = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if
        (str[i].Length > a)
        {
            a = str[i].Length;
            lengthWord = str[i];
        }
    }
    foreach (string i in str)
    {
        if (lengthWord.CompareTo(i) == 0)
        {
            repetition++;
        }
        if (lengthWord.Length == i.Length)
        {
            repetitionCounter++;
        }
    }
    Console.WriteLine($"Самое длинное слово {lengthWord} " +
        $"\n Количество повторений этого слова: {repetition}" +
        $"\n Количество слов такой же длинны: {repetitionCounter}");
}
static void ReplacingNumbers(string receivedString)
{
    for (int i = 0; i <= 9; i++)
    {
        string number = Convert.ToString(i);
        string numberString = Convert.ToString(i);
        switch (i)
        {
            case 0:
                {
                    numberString = "Ноль";
                    break;
                }
            case 1:
                {
                    numberString = "Один";
                    break;
                }
            case 2:
                {
                    numberString = "Два";
                    break;
                }
            case 3:
                {
                    numberString = "Три";
                    break;
                }
            case 4:
                {
                    numberString = "Четыре";
                    break;
                }
            case 5:
                {
                    numberString = "Пять";
                    break;
                }
            case 6:
                {
                    numberString = "Шесть";
                    break;
                }
            case 7:
                {
                    numberString = "Семь";
                    break;
                }
            case 8:
                {
                    numberString = "Восемь";
                    break;
                }
            case 9:
                {
                    numberString = "Девять";
                    break;
                }
        }
        receivedString = receivedString.Replace(number, numberString);
    }
    Console.WriteLine(receivedString);
}
