﻿// Вид 1
//void Method1()
//{
//    Console.WriteLine("автор ....");
//}
//Method1();



//void Method2(string msg)
//{
//   Console.WriteLine(msg);
//
//}
//Method2(msg: "Текст сообщения");

//void Method21(string msg, int count)
//{
//    int i = 0;
//    while (i < count)
//    {
//        Console.WriteLine(msg);
//        i++;
//    }
//
//}
//Method21(msg: "Текст", 4);
//Method21(count: 4, msg: "новый текст");

//int Method3()
//{
//    return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);

// вид 4

//string Method4(int count, string text)
//{
//    int i = 0;
//   string result = String.Empty;
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}

//string res = Method4(10, "z");
//Console.WriteLine(res);



//string Method4(int count, string text)
//{
//    string result = String.Empty;
//    for (int i = 0; i < count; i++)
//    {
//    result = result + text;
//}
//return result;
//}

//string res = Method4(10, "z");
//Console.WriteLine(res);

//for (int i = 2; i <= 10; i++)
//{
//    for (int j = 0; j <= 10; j++)
//    {
//        Console.WriteLine($"{i}*{j}={i * j}");
//   }
//    Console.WriteLine();
//}

// Дан тект. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К", а большие
// "С" заменить маленькими "с".


string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
// s[3] //r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }


    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine( );
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);




































