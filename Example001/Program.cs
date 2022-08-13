// Вмд 1
void Metod1()
{
Console.WriteLine("Вид 1. Автор...");
}

Metod1();

Console.WriteLine();

// Вмд 2
void Metod2(string msg)
{
    Console.WriteLine(msg);
}

Metod2("Вид 2. Текст сообщения");

Console.WriteLine();

// Вид 2.1
void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Либо так Metod21 ("Текст", 4);
Metod21(count: 4, msg: "Вид 2.1 Текст"); // либо так, причем порядок аргументов не важен

Console.WriteLine();

//Вид 3

int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);
Console.WriteLine();
//Вид 4

string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "Вид4_asdf");
Console.WriteLine(res);