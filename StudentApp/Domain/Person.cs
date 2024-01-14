namespace StudentApp.Domain;

/// <summary>
/// Абстрактный класс, представляющий человека
/// </summary>
/// <param name="name"></param>
/// <param name="age"></param>
internal abstract class Person(string name, int age)
{
    /// <summary>
    /// Внутреннее поле, хранящее имя человека
    /// </summary>
    public string Name { get; set; } = name;

    /// <summary>
    /// Внутреннее поле, хранящее возраст человека
    /// </summary>
    public int Age { get; set; } = age;

    public override string ToString() => $"""Person [name="{Name}", age="{Age}"]""";
}
