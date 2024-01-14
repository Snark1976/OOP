using System.Collections;
using System.Text;

namespace StudentApp.Domain;

/// <summary>
/// Класс, представляющий группу студентов
/// </summary>
/// <param name="group">Список студентов</param>
/// <param name="idGroup">Номер группы</param>
internal class StudentGroup(List<Student> group, int idGroup) : IEnumerable<Student>, IComparable<StudentGroup>
{
    /// <summary>
    /// Список студентов
    /// </summary>
    public List<Student> Students { get; set; } = group;

    /// <summary>
    /// Номер группы
    /// </summary>
    public int IdGroup { get; set; } = idGroup;

    public override string ToString()
    {
        StringBuilder sb = new($"StudentGroup {IdGroup}:\n");
        foreach ((Student st, int n) in Students.Order().Select((x, i) => (x, i + 1)))
            sb.AppendLine($"{n}. {st}");
        return sb.ToString();
    }

    public IEnumerator<Student> GetEnumerator() => new StudentEnumerator(Students);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public int CompareTo(StudentGroup? other)
    {
        if (other == null) return 1;
        int result = Math.Sign(Students.Count - other.Students.Count);
        return result == 0 ? Math.Sign(IdGroup - other.IdGroup) : result;
    }
}
