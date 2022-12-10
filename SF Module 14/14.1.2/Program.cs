using System.Linq;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] text = {  "Раз два три",
                           "четыре пять шесть",
                           "семь восемь девять" };

        var result = from str in text
                     from word in str.Split(" ")
                     select word;

        foreach (var word in result)
            Console.WriteLine(word);

    }
}