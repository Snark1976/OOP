using System.Numerics;

namespace MvcStudentApp.Domain;

/// <summary>
/// Абстрактный класс, представляющий человека
/// </summary>
/// <param name="name"></param>
/// <param name="age"></param>
internal abstract class Person<T, V>(T name, V age) where V : INumber<V>
{
    /// <summary>
    /// Внутреннее поле, хранящее имя человека
    /// </summary>
    public T Name { get; set; } = name;

    /// <summary>
    /// Внутреннее поле, хранящее возраст человека
    /// </summary>
    public V Age { get; set; } = age;

    public override string ToString() => $"""Person [name="{Name}", age="{Age}"]""";
}
