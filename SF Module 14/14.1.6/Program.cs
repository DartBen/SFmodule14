internal class Program
{
    private static void Main(string[] args)
    {
        var numsList = new List<int[]>()
            {
               new[] {2, 3, 7, 1},
               new[] {45, 17, 88, 0},
               new[] {23, 32, 44, -6},
            };


        //var NumCollection=from numA in numsList
        //                  from num in numA
        //                  orderby num
        //                  select(num);

        var NumCollection = numsList
               .SelectMany(x => x)
               .OrderBy(x => x);


        foreach (var num in NumCollection)
            Console.WriteLine(num);


    }
}