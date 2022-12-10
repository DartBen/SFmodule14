internal class Program
{
    private static void Main(string[] args)
    {
        string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

        //так фигня выходит
        var NewWords = words
            .OrderBy(words => words.Length)
            .Select(word => new { word } );

        foreach (var word in NewWords)
            Console.WriteLine(word.word);

        var NewWords2 = words
            .Select(word => new { kind = word, Lenght = word.Length })
            .OrderBy(word=> word.Lenght);

        foreach (var word in NewWords2)
            Console.WriteLine(word.kind);


    }
}