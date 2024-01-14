using System.Collections;

namespace StudentApp.Domain;

/// <summary>
/// Итератор для списка групп
/// </summary>
/// <param name="groups"></param>
internal class StreamEnumerator(List<StudentGroup> groups) : IEnumerator<StudentGroup>
{
    private readonly List<StudentGroup> _groups = groups;
    private int _position = -1;

    public StudentGroup Current
    {
        get
        {
            if (_position == -1 || _position >= _groups.Count)
                throw new ArgumentException();
            return _groups[_position];
        }
    }
    object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext() => ++_position < _groups.Count;

    public void Reset() { _position = -1; }
}
