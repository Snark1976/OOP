using MvcStudentApp.Controller.Interfaces;
using MvcStudentApp.Domain;

namespace MvcStudentApp.Model;

/// <summary>
/// Класс, реализующий модель данных, где в качестве хранилища используется словарь
/// </summary>
/// <param name="students"></param>
internal class ModelClassHash(List<Student> students) : IModel
{
    /// <summary>
    /// хранилище студентов
    /// </summary>
    private readonly Dictionary<int, Student> _students = students.ToDictionary(stud => stud.Id);

    /// <summary>
    /// Свойство, предоставляющее доступ на чтение к хранилищу
    /// </summary>
    public IReadOnlyList<Student> Students => _students.Values.ToList();

    /// <summary>
    /// Метод удаления студента из списка
    /// </summary>
    /// <param name="studentId"></param>
    /// <returns></returns>
    public bool DeleteStudent(int studentId) => _students.Remove(studentId);
}
