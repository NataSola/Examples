// Методы

// Вид 1. Методы, которые ничего не принимают и ничего не возвращают

void Method1()
{
    Console.WriteLine("Распечатано: " + DateTime.Now);
}
Method1(); // вызов метода - обязательно со скобками


// Вид 2. Методы, которые ничего не возвращают, но могут что-то принимать

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("New Text", 3); // аргументы записываются по порядку
Method21(count: 2, msg: "Named arguments"); // именованные аргументы могут записываться в любом порядке

// Вид 3. Методы, которые что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// Вид 4. Методы, которые что-то принимают и что-то возвращают

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "00/");
Console.WriteLine(res);

