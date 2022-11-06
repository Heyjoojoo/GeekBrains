// 1 Вид методов
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

//2 Вид методов

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст сообщения", 4);
Method21(count: 4, msg: "Новый текст");

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4 

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

string res = Method4(10, "asdf");
Console.WriteLine(res);


string Method41(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
        i++;
    }
    return result;
}

string resshmez = Method41(10, "asdf");
Console.WriteLine(resshmez);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i*j}");
    }
}

string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace (string text, char OldValue, char NewValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == OldValue)
            result = result + $"{NewValue}";
            else result = result + $"{text[i]}";
    }


    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'k', 'K');
Console.WriteLine(newText);
