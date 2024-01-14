using StudentApp.Domain;

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
    Console.WriteLine(group);

Console.WriteLine(stream);