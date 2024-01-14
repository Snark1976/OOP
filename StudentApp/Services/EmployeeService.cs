using StudentApp.Domain;

namespace StudentApp.Services;

internal class EmployeeService : IPersonServices<Employee>
{
    public List<Employee> Persons { get; } = [];
}
