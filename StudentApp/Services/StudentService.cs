using StudentApp.Domain;

namespace StudentApp.Services;
internal class StudentService : IPersonServices<Student>
{
    public List<Student> Persons { get; } = [];
}
