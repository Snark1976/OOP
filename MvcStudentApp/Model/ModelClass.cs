using MvcStudentApp.Controller.Interfaces;
using MvcStudentApp.Domain;

namespace MvcStudentApp.Model;

/// <summary>
/// Класс, реализующий модель данных, где в качестве хранилища используется список
/// </summary>
/// <param name="students"></param>
internal class ModelClass(IEnumerable<Student> students) : IModel
{
    /// <summary>
    /// хранилище студентов
    /// </summary>
    readonly List<Student> _students = students.ToList();

    /// <summary>
    /// Свойство, предоставляющее доступ на чтение к хранилищу
    /// </summary>
    public IReadOnlyList<Student> Students => _students;

    /// <summary>
    /// Метод удаления студента из списка
    /// </summary>
    /// <param name="studentId"></param>
    /// <returns></returns>
    public bool DeleteStudent(int studentId)
    {
        Student? student = Students.FirstOrDefault(x => x.Id == studentId);
        if (student == null) return false;
        _students.Remove(student);
        return true;
    }
}
