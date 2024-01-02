namespace Market.Classes;

/// <summary>
/// Класс, представляющий специального клиента.
/// </summary>
/// <param name="name">Имя клиента.</param>
/// <param name="vipId">Уникальный идентификатор специального клиента.</param>
public class SpecialClient(string name, int vipId) : Actor(name)
{
    /// <summary>
    /// Уникальный идентификатор специального клиента.
    /// </summary>
    public int VipId { get; set; } = vipId;
}
