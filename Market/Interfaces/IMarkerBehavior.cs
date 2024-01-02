namespace Market.Interfaces
{
    /// <summary>
    /// Интерфейс для управления поведением магазина.
    /// </summary>
    public interface IMarkerBehavior
    {
        /// <summary>
        /// Метод для принятия клиента в магазин.
        /// </summary>
        /// <param name="actor">Клиент для принятия в магазин.</param>
        void AcceptToMarket(IActorBehavior actor);

        /// <summary>
        /// Метод для освобождения клиентов из магазина.
        /// </summary>
        /// <param name="actors">Список клиентов для освобождения из магазина.</param>
        void ReleaseFromMarket(List<IActorBehavior> actors);

        /// <summary>
        /// Метод для обновления состояния магазина.
        /// </summary>
        void Update();
    }
}
