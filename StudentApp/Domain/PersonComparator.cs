namespace StudentApp.Domain;
internal class PersonComparator<T> : IComparer<T> where T : Person<string, int>
{
    public int Compare(T? x, T? y) => x is not null && y is not null
        ? x.Name.CompareTo(y.Name)
        : throw new ArgumentException("Некорректное значение параметра");
}
