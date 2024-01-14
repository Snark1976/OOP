using StudentApp.Domain;
using System.Numerics;

namespace StudentApp.Controllers;
internal class AccountController
{
    /// <summary>
    /// Метод начисления зарплаты работнику
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="V"></typeparam>
    /// <param name="worker"></param>
    /// <param name="salary"></param>
    public static void PaySalary<T, V>(T worker, V salary) where T : Worker<string, int, string> where V : INumber<V>
    {
        Console.WriteLine($"{worker} выплачена зарплата {salary}");
    }

    /// <summary>
    /// Метод вычисления среднего возраста для перечисления работников
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="persons"></param>
    /// <returns></returns>
    public static double AverageAge<T>(IEnumerable<T> persons) where T : Person<string, int> =>
        (double)persons.Sum(x => x.Age) / persons.Count();
}
