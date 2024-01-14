namespace StudentApp.Domain;

/// <summary>
/// Класс, представляющий преподавателя
/// </summary>
/// <param name="name"></param>
/// <param name="age"></param>
/// <param name="acadDegree"></param>
internal class Teacher(string name, int age, string jobTitle) : Worker<string, int, string>(name, age, jobTitle)
{
    public override string ToString() => $"""Teacher [name = "{Name}", age = "{Age}", degree = "{JobTitle}"]""";
}