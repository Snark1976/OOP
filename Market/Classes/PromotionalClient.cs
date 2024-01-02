namespace Market.Classes
{
    /// <summary>
    /// Класс, представляющий акционного клиента, участвующего в акциях магазина.
    /// </summary>
    /// <remarks>
    /// Конструктор класса для создания экземпляра акционного клиента.
    /// </remarks>
    /// <param name="name">Имя актера (клиента).</param>
    /// <param name="promotionName">Название акции, в которой участвует клиент.</param>
    public class PromotionalClient(string name, string promotionName) : Actor(name)
    {
        public string PromotionName { get; set; } = promotionName;

        // При создании нового клиента увеличиваем счетчик участников акции и присваиваем номер участника клиенту
        public int ClientId { get; } = ++ParticipantsCount;

        public static int ParticipantsCount { get; set; }
    }
}
