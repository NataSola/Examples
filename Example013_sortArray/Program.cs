// Другие циклы

string Method4(int count, string txt)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + txt;
    }
    return result;
}

string res = Method4(10, "00/");
Console.WriteLine(res);

// Цикл внутри цикла

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}