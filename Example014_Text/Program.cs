// Дан текст. Все побелы нужно заменить черточками, 
// маленькие буквы "к" заменить большими "К",
// большие "С" заменить маленькими "с"

string text = "Витька коротко глянул на меня, и я присел."
            + "Шутки кончились. Витька находился в том состоянии,"
            + "когда увлеченные работой маги превращают окружающих "
            + "в пауков, мокриц, ящериц и других тихих животных. (С)";

string Replace(string text, char oldValue, char newValue)  // это метод
{
    string result = string.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ','|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к','К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С','с');
Console.WriteLine(newText);
Console.WriteLine();
