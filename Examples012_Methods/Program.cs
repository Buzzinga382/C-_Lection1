﻿// Type 1

void Method1()
{
    Console.WriteLine("Author...");
}
//Method1();



// Type 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Text");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Text", 4);
//Method21(msg: "Text", count: 4);



// Type 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);



// Type 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "text");
Console.WriteLine(res);