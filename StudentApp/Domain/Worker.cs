using System.Numerics;

namespace StudentApp.Domain;

/// <summary>
/// Интерфейс для определения наемных работников
/// </summary>
internal class Worker<T, V, U>(T name, V age, U jobTitle) : Person<T, V>(name, age) where V : INumber<V>
{
    /// <summary>
    /// Внутреннее поле, хранящее должность сотрудника
    /// </summary>
    public U JobTitle { get; } = jobTitle;
}