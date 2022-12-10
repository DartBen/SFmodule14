using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        //string a = "А";
        //char ch = a[0];

        List<string> list = new List<string>();

        foreach (string s in people)
        {
            //if (s[0] == ch)
            if (s.ToUpper().StartsWith("А"))
            { list.Add(s); }
            continue;
        }

        if (list.Count > 0)
        {
            list.Sort();
        }

        foreach (string s in list)
        {
            Console.WriteLine(s);
        }

    }
}