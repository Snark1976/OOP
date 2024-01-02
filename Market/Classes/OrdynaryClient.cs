namespace Market.Classes;

/// <summary>
/// Класс, представляющий обычного клиента.
/// </summary>
/// <param name="name">Имя клиента.</param>
public class OrdinaryClient(string name) : Actor(name)
{ }
