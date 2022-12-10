using _14._2._3;

internal class Program
{
    private static void Main(string[] args)
    {
        // Наш список студентов
        List<Student> students = new List<Student>
                    {
                       new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                       new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                       new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                       new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
                    };


        var anketa = from student in students
                     where student.Age >= 27
                     let tmpYearOfBirth = DateTime.Now.Year - student.Age
                     select new Application()
                     {
                         Name = student.Name,
                         YearOfBirth = tmpYearOfBirth
                     };

        foreach (var student in anketa) 
            Console.WriteLine(student.Name+" "+ student.YearOfBirth);

    }
}