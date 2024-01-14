using System.Collections;

namespace StudentApp.Domain;

/// <summary>
/// Итератор для списка студентов
/// </summary>
/// <param name="group"></param>
internal class StudentEnumerator(List<Student> group) : IEnumerator<Student>
{
    private readonly List<Student> _students = group;
    private int _position = -1;

    object IEnumerator.Current => Current;

    public void Dispose() { }

    public Student Current
    {
        get
        {
            if (_position == -1 || _position >= _students.Count)
                throw new ArgumentException();
            return _students[_position];
        }
    }

    public bool MoveNext() => ++_position < _students.Count;

    public void Reset() { _position = -1; }
}

