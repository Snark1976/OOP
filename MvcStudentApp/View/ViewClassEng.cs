using MvcStudentApp.Controller.Interfaces;
using MvcStudentApp.Domain;

namespace MvcStudentApp.View;

/// <summary>
/// Класс, реализующий IView с использованием английского языка
/// </summary>
internal class ViewClassEng : IView
{
    /// <summary>
    /// Вывод списка студентов
    /// </summary>
    /// <param name="students"></param>
    public void PrintAllStudent(IEnumerable<Student> students)
    {
        Console.WriteLine("**************  Student list  **************");
        students.ToList().ForEach(Console.WriteLine);
        Console.WriteLine("********************************************");
        Console.WriteLine();
    }

    /// <summary>
    /// Метод, отправляющий вопрос пользователю и принимающий ответ о него
    /// </summary>
    /// <param name="msg"></param>
    /// <returns></returns>
    public string Prompt(string msg)
    {
        Console.WriteLine(msg);
        return Console.ReadLine()!;
    }

    /// <summary>
    /// Метод, отправляющий сообщение пользователю
    /// </summary>
    /// <param name="msg"></param>
    public void SendMessage(string msg) => Console.WriteLine(msg);
}