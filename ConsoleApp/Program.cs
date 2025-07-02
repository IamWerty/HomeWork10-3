using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть рядок зі словами, розділеними комами: ");
string input = Console.ReadLine();

string result = input.Replace(" ", "");

Console.WriteLine("Результат без пробілів:");
Console.WriteLine(result);