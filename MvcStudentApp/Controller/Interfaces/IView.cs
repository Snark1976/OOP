using MvcStudentApp.Domain;

/// <summary>
/// Интерфейс для представления информации
/// </summary>
namespace MvcStudentApp.Controller.Interfaces;
internal interface IView
{
    /// <summary>
    /// Вывод списка студентов
    /// </summary>
    /// <param name="students"></param>
    void PrintAllStudent(IEnumerable<Student> students);

    /// <summary>
    /// Метод, отправляющий вопрос пользователю и принимающий ответ о него
    /// </summary>
    /// <param name="msg"></param>
    /// <returns></returns>
    string Prompt(string msg);

    /// <summary>
    /// Метод, отправляющий сообщение пользователю
    /// </summary>
    /// <param name="msg"></param>
    void SendMessage(string msg);
}