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

Console.Write("Введите слово: ");
string word = Console.ReadLine();
int counter = 0;

foreach (char c in word.ToLower())
{
    if (c == 'а') {
        counter++;
    }
}
Console.WriteLine($"Букв 'а' в вашем слове: {counter}");