namespace StudentApp.Domain;

/// <summary>
/// Класс, представляющий студента
/// </summary>
/// <param name="name"></param>
/// <param name="age"></param>
internal class Student(string name, int age) : Person<string, int>(name, age), IComparable<Student>
{
    /// <summary>
    /// Внутреннее статическое поле, хранящее последний присвоенный идентификационный номер студента
    /// </summary>
    private static int _generalId = 0;

    /// <summary>
    /// Свойство, хранящее идентификационный номер студента
    /// </summary>
    public int Id { get; init; } = _generalId++;

    /// <summary>
    /// Сравнение студентов происходит сначала по Age, а затем по Id
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public int CompareTo(Student? other)
    {
        if (other == null) return 1;
        int result = Math.Sign(Age - other.Age);
        return result == 0 ? Math.Sign(Id - other.Id) : result;
    }

    public override string ToString() => $"""Student [name = "{Name}", age = "{Age}", id = "{Id}"]""";
}
