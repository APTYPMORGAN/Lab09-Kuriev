using System.Text;

// string word = "Привет";

// Console.WriteLine(word.Length);
// Console.WriteLine(word[0]);

// foreach (char c in word)
// {
//     Console.WriteLine(c);
// }

// string file = "report_final.docx";

// Console.WriteLine(file.Contains("final"));
// Console.WriteLine(file.StartsWith("report"));
// Console.WriteLine(file.EndsWith(".docx"));

// string text = "Hello World";

// Console.WriteLine(text.ToUpper());
// Console.WriteLine(text.ToLower());
// Console.WriteLine(text.Replace("World", "C#"));

// string lower = text.ToLower();

// Console.WriteLine(lower);

// string s = "Programming";

// Console.WriteLine(s.Substring(0, 3));
// Console.WriteLine(s.Substring(3));

// string name = "анна";
// Console.WriteLine($"Привет, {name.ToUpper()}! В твоём имени {name.Length} буквы.");

// Console.Write("Введите слово: ");
// string word1 = Console.ReadLine();

// Console.WriteLine($"Длина: {word1.Length}");
// Console.WriteLine($"Первый символ: {word1[0]}");
// Console.WriteLine($"Последний символ: {word[word1.Length - 1]}");


// Console.Write("Введите слово: ");
// string word = Console.ReadLine();
// int counter = 0;

// foreach (char c in word.ToLower())
// {
//     if (c == 'а') {
//         counter++;
//     }
// }
// Console.WriteLine($"Букв 'а' в вашем слове: {counter}");


// Console.Write("Имя файла: ");
// string fileName = Console.ReadLine();

// if (fileName.EndsWith(".cs"))
// {
//     Console.WriteLine("Это файл C#");
// }
// else if (fileName.EndsWith(".png"))
// {
//     Console.WriteLine("Этот файл - изображение");
// }
// else if (fileName.EndsWith(".jpg"))
// {
//     Console.WriteLine("Этот файл - изображение");
// }
// else
// {
//     Console.WriteLine("Неизвестный тип");
// }
// if (fileName.StartsWith("Lab"))
// {
//     Console.WriteLine("Это лабораторная работа");
// }
// if (fileName.Contains("test"))
// {
//     Console.WriteLine("Тестовый файл");
// }


// Console.Write("Вы согласны? (да/нет): ");
// string answer = Console.ReadLine();

// if (answer.ToLower() == "да")
// {
//     Console.WriteLine("Отлично!");
// }


// Console.Write("Введите фразу: ");
// string answer = Console.ReadLine();

// Console.WriteLine(answer.ToUpper());
// Console.WriteLine(answer.Replace(" ", "_"));
// if (answer.ToLower().Contains("стоп"))
// {
//     Console.WriteLine("Стоп-слово найдено!");
// }


// Console.Write("Введите дату: ");
// string date = Console.ReadLine();
// string year = date.Substring(0, 4);
// string month = date.Substring(5, 2);
// string day = date.Substring(8, 2);
// Console.WriteLine($"{day}.{month}.{year}");

// Console.Write("Введите номер телефона: ");
// string number = Console.ReadLine();
// string first = number.Substring(1, 3);
// string second = number.Substring(4, 3);
// string pre_last = number.Substring(7, 2);
// string last = number.Substring(9, 2);
// Console.WriteLine($"+7 ({first}) {second}-{pre_last}-{last}");


// Console.Write("Введите строку: ");
// string text = Console.ReadLine();
// Console.WriteLine($"Количество символов в строке: {text.Length}");
// int counter_space = 0;
// foreach (char c in text)
// {
//     if (c == ' ')
//     {
//         counter_space++;
//     }
// }
// Console.WriteLine($"Количество пробелов в строке: {counter_space}");
// string glass = "аеёиоуыэюя";
// int counter_glass = 0;
// foreach (char c in glass)
// {
//     if (text.Contains(c))
//     {
//         foreach (char v in text)
//         {
//             if (v == c)
//             {
//                 counter_glass++;
//             }
//         }
//     }
// }
// Console.WriteLine($"Количество гласных в строке: {counter_glass}");


// Console.Write("Введите слово: ");
// string word = Console.ReadLine();
// string new_word = "";
// for (int i = word.Length - 1; i >= 0; i--)
// {
//     new_word += word[i];
// }
// Console.WriteLine(new_word);
// if (new_word.ToLower() == word.ToLower())
// {
//     Console.WriteLine("Слово является палиндромом");
// } else
// {
//     Console.WriteLine("Слово не является палиндромом");
// }


// Console.Write("Введите адрес электронной почты: ");
// string email = Console.ReadLine();
// string error = "";

// bool flag = true;

// if (email.Length < 5)
// {
//     flag = false;
//     error += "\nДлина почты менее 5 символов";
// }

// int counter_dogs = 0;
// foreach (char c in email)
// {
//     if (c == '@')
//     {
//         counter_dogs++;
//     }
// }
// if (counter_dogs != 1)
// {
//     flag = false;
//     error += "\nКоличество символов @ не равняется одному";
// }

// if (email.StartsWith("@") == true)
// {
//     flag = false;
//     error += "\nПочта начинается с @";
// }
// if (email.EndsWith("@") == true)
// {
//     flag = false;
//     error += "\nПочта заканчивается на @";
// }

// if (email.Contains(" ") == true)
// {
//     flag = false;
//     error += "\nПочта содержит пробел";
// }

// if (email.ToLower().EndsWith(".ru") == false && email.ToLower().EndsWith(".com") == false)
// {
//     flag = false;
//     error += "\nПочта не заканчивается на .ru или .com";
// }

// if (flag == true)
// {
//     Console.WriteLine($"Адрес корректен {email.ToLower()}");
// } else
// {
//     Console.WriteLine($"Адрес некорректен.\nПричина: {error}");
// }


Console.Write("Введите строку теста: ");
string text = Console.ReadLine();
string glass = "аеёиоуыэюя";

var new_text = new StringBuilder();
foreach (char c in text.ToLower())
{
    if (glass.Contains(c) == false)
    {
        new_text.Append(c);
    }
}
Console.WriteLine(new_text.ToString());