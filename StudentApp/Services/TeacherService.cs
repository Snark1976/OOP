using StudentApp.Domain;

namespace StudentApp.Services;

/// <summary>
/// Класс для представления объединения преподавателей
/// </summary>
internal class TeacherService : IPersonServices<Teacher>
{
    /// <summary>
    /// Список преподавателей в объединении
    /// </summary>
    public List<Teacher> Persons { get; } = [];

    public void PrintTeachers()
    {
        ((IPersonServices<Teacher>)this).SortByFio();
        Persons.ForEach(Console.WriteLine);
    }
}