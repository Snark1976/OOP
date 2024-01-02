using Market.Classes;

namespace Market.Interfaces
{
    /// <summary>
    /// Интерфейс для описания поведения клиента в магазине.
    /// </summary>
    public interface IActorBehavior
    {
        /// <summary>
        /// Свойство, указывающее, взял ли клиент заказ.
        /// </summary>
        bool IsTakeOrder { get; set; }

        /// <summary>
        /// Свойство, указывающее, сделал ли клиент заказ.
        /// </summary>
        bool IsMakeOrder { get; set; }

        /// <summary>
        /// Экземпляр клиента.
        /// </summary>
        Actor ThisActor { get; }
    }
}
