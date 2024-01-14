using System.Collections;
using System.Text;

namespace StudentApp.Domain;

internal class StudentStream(int streamId, List<StudentGroup> groups) : IEnumerable<StudentGroup>
{
    public int StreamId { get; } = streamId;

    public List<StudentGroup> Groups { get; } = groups;

    public IEnumerator<StudentGroup> GetEnumerator() => new StreamEnumerator(Groups);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public override string ToString() 
    { 
        StringBuilder sb = new($"Поток {StreamId}, количество групп: {Groups.Count}\n");
        foreach ((Student st, int n) in Groups.SelectMany(x => x).Order().Select((x, i) => (x, i + 1)))
            sb.AppendLine($"{n}. {st}");
        return sb.ToString();
    }
}
