using MvcStudentApp.Domain;

namespace MvcStudentApp.Controller.Interfaces;

/// <summary>
/// Интерфейс, представляющий модель данных
/// </summary>
internal interface IModel
{
    /// <summary>
    /// Свойство, предоставляющее доступна на чтение к списку студентов
    /// </summary>
    IReadOnlyList<Student> Students { get; }

    /// <summary>
    /// Метод удаления студента из списка
    /// </summary>
    /// <param name="studentId"></param>
    /// <returns></returns>
    bool DeleteStudent(int studentId);
}