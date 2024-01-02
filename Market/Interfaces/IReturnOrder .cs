namespace Market.Interfaces
{
    /// <summary>
    /// Интерфейс для описания возврата товара клиентом.
    /// </summary>
    public interface IReturnOrder
    {
        /// <summary>
        /// Метод для возврата заказанного товара.
        /// </summary>        
        /// <param name="refundAmount">Сумма, подлежащая возврату.</param>
        /// <returns>Статус возврата товара: успешно или неудачно.</returns>
        bool ReturnOrderedItem(out decimal refundAmount);

        /// <summary>
        /// Метод для возврата денежных средств за заказанный товар.
        /// </summary>
        /// <param name="refundAmount">Сумма, подлежащая возврату.</param>
        /// <returns>Статус возврата денежных средств: успешно или неудачно.</returns>
        bool RefundMoney(decimal refundAmount);
    }
}
