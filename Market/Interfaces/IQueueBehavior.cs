namespace Market.Interfaces
{
    /// <summary>
    /// Интерфейс для описания поведения очереди в магазине.
    /// </summary>
    public interface IQueueBehavior
    {
        /// <summary>
        /// Метод для помещения клиента в очередь.
        /// </summary>
        /// <param name="actor">Клиент для добавления в очередь.</param>
        void TakeInQueue(IActorBehavior actor);

        /// <summary>
        /// Метод для освобождения клиентов из очереди.
        /// </summary>
        void ReleaseFromQueue();

        /// <summary>
        /// Метод для принятия заказов от клиентов в очереди.
        /// </summary>
        void TakeOrder();

        /// <summary>
        /// Метод для выдачи заказов клиентам из очереди.
        /// </summary>
        void GiveOrder();
    }
}