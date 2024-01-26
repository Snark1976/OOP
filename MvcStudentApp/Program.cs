using MvcStudentApp.Controller;
using MvcStudentApp.Controller.Interfaces;
using MvcStudentApp.Domain;
using MvcStudentApp.Model;
using MvcStudentApp.View;

List<Student> listStud =
    [
        new("Иван", 25),
        new("Игорь", 23),
        new("Иван", 22),
        new("Игорь", 23),
        new("Даша", 23),
        new("Лена", 23),
        new("Иван", 22),
        new("Павел", 21),
        new("Иван", 23),
        new("Игорь", 21),
        new("Петр", 24),
        new("Елена", 22),
        new("Антон", 21),
        new("Иван", 23),
        new("Игорь", 22),
        new("Антон", 21)
    ];

IModel model = new ModelClassHash(listStud);
IView view = new ViewClassEng();

IController controller = new ControllerClass(model, view);

controller.Run();