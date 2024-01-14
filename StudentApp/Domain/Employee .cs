namespace StudentApp.Domain;

/// <summary>
/// Класс, представляющий сотрудника
/// </summary>
/// <param name="name"></param>
/// <param name="age"></param>
/// <param name="jobTitle"></param>
internal class Employee(string name, int age, string jobTitle) : Worker<string, int, string>(name, age, jobTitle)
{
    public override string ToString() => $"""Employee [name = "{Name}", age = "{Age}", degree = "{JobTitle}"]""";
}
