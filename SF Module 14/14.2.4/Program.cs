using _14._2._4;
using System.Runtime.InteropServices;

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

        // Список курсов
        var coarses = new List<Coarse>
                    {
                       new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                       new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
                    };

        var NewCollection = from student in students
                            from coarse in coarses
                            where student.Languages.Contains("английский")
                            where coarse.Name.Contains("Язык программирования C#")
                            let birthDate=DateTime.Now.Year - student.Age 
                            select new { Name = student.Name, BirthDate= birthDate,   CoarseName = coarse.Name };


        foreach (var stud in NewCollection)
            Console.WriteLine(stud.Name +" "+ stud.BirthDate +" года рождения"+ " добавлен в "+stud.CoarseName);
    }
}