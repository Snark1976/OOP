using MvcStudentApp.Controller.Interfaces;
using MvcStudentApp.Domain;

namespace MvcStudentApp.View;

/// <summary>
/// Класс, реализующий IView с использованием русского языка
/// </summary>
internal class ViewClass : IView
{
    public void PrintAllStudent(IEnumerable<Student> students)
    {
        Console.WriteLine("************  Список студентов  ************");
        students.ToList().ForEach(Console.WriteLine);
        Console.WriteLine("********************************************");
        Console.WriteLine();
    }

    public string Prompt(string msg)
    {
        Console.WriteLine(msg);
        return Console.ReadLine()!;
    }

    public void SendMessage(string msg) => Console.WriteLine(msg);
}
