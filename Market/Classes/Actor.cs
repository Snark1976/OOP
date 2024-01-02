using Market.Interfaces;

namespace Market.Classes;

/// <summary>
/// Абстрактный класс, представляющий клиента в магазине.
/// Реализует интерфейс IActorBehavior для определения поведения актера.
/// </summary>
/// <param name="name">Имя актера (клиента).</param>
public abstract class Actor(string name) : IActorBehavior, IReturnOrder
{
    /// <summary>
    /// Внутреннее поле, хранящее имя клиента.
    /// </summary>
    public string Name { get; set; } = name;

    /// <summary>
    /// Флаг, указывающий, сделал ли клиент заказ.
    /// </summary>
    public bool IsMakeOrder { get; set; }

    /// <summary>
    /// Флаг, указывающий, взял ли клиент заказ.
    /// </summary>
    public bool IsTakeOrder { get; set; }

    /// <summary>
    /// Свойство для доступа к экземпляру актера (клиента).
    /// </summary>
    public Actor ThisActor => this;

    /// <summary>
    /// Метод для возврата заказанного товара клиентом.
    /// </summary>
    /// <param name="refundAmount">Сумма, подлежащая возврату.</param>
    /// <returns>Статус возврата товара: успешно или неудачно.</returns>
    public bool ReturnOrderedItem(out decimal refundAmount)
    {
        refundAmount = CheckReturnOrder();
        return refundAmount > 0;
    }

    /// <summary>
    /// Метод для возврата денежных средств за заказанный товар.
    /// </summary>
    /// <param name="actor">Клиент, который возвращает товар.</param>
    /// <param name="refundAmount">Сумма, подлежащая возврату.</param>
    /// <returns>Статус возврата денежных средств: успешно или неудачно.</returns>
    public bool RefundMoney(decimal refundAmount)
    {
        // Здесь должна быть логика возврата денег...
        return true;
    }

    /// <summary>
    /// Метод для проверки возврата товара клиентом.
    /// </summary>
    /// <returns>Сумма, которую разрешено возвратить, если возврат товара запрещен, то будет возвращен 0</returns>
    private decimal CheckReturnOrder()
    {
        // Здесь должна быть логика проверки заявки на возврат товара (чек, целостность упаковки и т.п.)
        // Заменено "заплаткой": если случайное значение суммы возврата равно 0, то считаем, что возврат запрещен
        int refundAmount = new Random().Next(3);
        return refundAmount;
    }
}
