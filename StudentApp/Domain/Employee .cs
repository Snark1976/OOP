namespace StudentApp.Domain;

/// <summary>
/// Класс, представляющий сотрудника
/// </summary>
/// <param name="name"></param>
/// <param name="age"></param>
/// <param name="special"></param>
internal class Employee(string name, int age, string special) : Person(name, age)
{
    /// <summary>
    /// Внутреннее поле, хранящее должность сотрудника
    /// </summary>
    public string Special { get; } = special;
}
