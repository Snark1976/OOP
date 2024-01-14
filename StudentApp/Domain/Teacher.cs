namespace StudentApp.Domain;

/// <summary>
/// Класс, представляющий преподавателя
/// </summary>
/// <param name="name"></param>
/// <param name="age"></param>
/// <param name="acadDegree"></param>
internal class Teacher(string name, int age, string academicalDegree) : Person(name, age)
{
    /// <summary>
    /// Внутреннее поле, хранящее должность преподавателя
    /// </summary>
    public string AcademicalDegree { get; } = academicalDegree;
}