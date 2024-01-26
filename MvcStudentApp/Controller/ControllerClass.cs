using MvcStudentApp.Controller.Interfaces;
using MvcStudentApp.Domain;

namespace MvcStudentApp.Controller;

/// <summary>
/// Класс, реализующий функциональность контроллера 
/// </summary>
/// <param name="model"></param>
/// <param name="view"></param>
internal class ControllerClass(IModel model, IView view) : IController
{
    /// <summary>
    /// Буфер студентов
    /// </summary>
    private List<Student> _studBuffer = [];

    public IModel Model { get; } = model;

    public IView View { get; } = view;

    /// <summary>
    /// Обновление буфера и вывод его содержимого
    /// </summary>
    public void Update()
    {
        _studBuffer = [.. Model.Students];
        if (_studBuffer.Any())
            View.PrintAllStudent(Model.Students);
        else
            Console.WriteLine("Список студентов пуст!");
    }

    /// <summary>
    /// Метод, реализующий цикл обработки команд пользователя 
    /// </summary>
    public void Run()
    {
        bool getNewIteration = true;
        while (getNewIteration)
        {
            string command = View.Prompt("Введите команду:");
            if (!Enum.TryParse(command, true, out Command com))
            {
                View.SendMessage("Неверная команда");
                continue;
            }
            switch (com)
            {
                case Command.EXIT:
                    getNewIteration = false;
                    View.SendMessage("Выход из программы");
                    break;
                case Command.LIST:
                    View.PrintAllStudent(Model.Students);
                    break;
                case Command.DELETE:
                    DeleteStudent();
                    break;
                default:
                    View.SendMessage("Необрабатываемая команда");
                    break;
            }
        }
    }

    /// <summary>
    /// Метод удаления студента из хранилища
    /// </summary>
    private void DeleteStudent()
    {
        Update();
        if (_studBuffer.Any())
        {
            int id = int.Parse(View.Prompt("Введите ID студента:"));
            if (Model.DeleteStudent(id))
                View.SendMessage($"Студент с ID {id} удален");
            else
                View.SendMessage($"Студент с ID {id} не найден");
        }    
        else
            View.SendMessage("Список студентов пуст!");
        Update();
    }
}