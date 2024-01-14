using StudentApp.Domain;

namespace StudentApp.Services;

/// <summary>
/// Обобщенный интерфейс для объединений людей
/// Использованы для эксперимента явные реализации методов интерфейса
/// </summary>
/// <typeparam name="T"></typeparam>
internal interface IPersonServices<T> where T : Person<string, int>
{
    /// <summary>
    /// Список людей
    /// </summary>
    List<T> Persons { get; }

    /// <summary>
    /// Добавление человека в объединение
    /// </summary>
    /// <param name="person">Экземпляр человека</param>
    void Add(T person)
    {
        Persons.Add(person);
        SortByFio();
    }

    /// <summary>
    /// Выполнение сортировки списка людей
    /// </summary>
    void SortByFio()
    {
        PersonComparator<T> comparator = new();
        Persons.Sort(comparator);
    }
}
