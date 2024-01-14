using StudentApp.Controllers;
using StudentApp.Domain;
using StudentApp.Services;

List<Student> listStud1 =
    [
        new("Иван", 25),
        new("Игорь", 23),
        new("Иван", 22),
        new("Игорь", 23),
        new("Даша", 23),
        new("Лена", 23),
    ];

List<Student> listStud2 =
    [
        new("Иван", 22),
        new("Павел", 21),
        new("Иван", 23),
        new("Игорь", 21),
        new("Петр", 24),
        new("Елена", 22),
        new("Антон", 21),
    ];

List<Student> listStud3 =
    [
        new("Иван", 23),
        new("Игорь", 22),
        new("Антон", 21),
    ];

List<StudentGroup> groups =
    [
        new(listStud1, 4580),
        new(listStud2, 4583),
        new(listStud3, 4584),
    ];

StudentStream stream = new(15, groups);

foreach (StudentGroup group in stream.Groups.Order())
{
    Console.Write(group);
    Console.WriteLine($"Средний возраст {AccountController.AverageAge(group)}\n");
}

Console.Write(stream);
Console.WriteLine($"Средний возраст {AccountController.AverageAge(stream.Groups.SelectMany(x => x))}\n");

Teacher t1 = new("Эдуард", 50, "Доцент");
Teacher t2 = new("Алексей", 27, "Ассистент");
Teacher t3 = new("Леопольд", 56, "Профессор");
Teacher t4 = new("Франк", 44, "Преподаватель");
Employee e1 = new("Федор", 35, "Дворник");

AccountController.PaySalary(t1, 30000);
AccountController.PaySalary(e1, 70000);
//AccountController.PaySalary(stream.Groups[0].Students[0], 50000);


Console.WriteLine("\n---------------------------------------\n");

TeacherService service = new();
((IPersonServices<Teacher>)service).Add(t1);
((IPersonServices<Teacher>)service).Add(t2);
((IPersonServices<Teacher>)service).Add(t3);
((IPersonServices<Teacher>)service).Add(t4);
service.PrintTeachers();
Console.WriteLine($"Средний возраст {AccountController.AverageAge(service.Persons)}");
