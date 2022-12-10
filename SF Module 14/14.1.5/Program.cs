internal class Program
{
    private static void Main(string[] args)
    {
        var companies = new Dictionary<string, string[]>();

        companies.Add("Apple", new[] { "Mobile", "Desktop" });
        companies.Add("Samsung", new[] { "Mobile" });
        companies.Add("IBM", new[] { "Desktop" });



        var result = companies.Where(company => company.Value.Contains("Mobile"));





        foreach (var company in result)
            Console.WriteLine(company.Key);
    }
}