using Market.Interfaces;
using Market.Services;

namespace Market.Classes
{
    /// <summary>
    /// Класс, представляющий магазин.
    /// </summary>
    public class Shop(Logger logger, Dictionary<string, int> promotions) : IMarkerBehavior, IQueueBehavior
    {
        private readonly List<IActorBehavior> _queue = [];
        private readonly Logger _logger = logger;
        private readonly Dictionary<string, int> _promotions = promotions;

        /// <summary>
        /// Вход клиента в магазин.
        /// </summary>
        /// <param name="actor">Клиент.</param>
        public void AcceptToMarket(IActorBehavior actor)
        {
            _logger.LogToFile($"Клиент {actor.ThisActor.Name} пришел в магазин");
            TakeInQueue(actor);
        }

        /// <summary>
        /// Помещение клиента в очередь.
        /// </summary>
        /// <param name="actor">Клиент.</param>
        public void TakeInQueue(IActorBehavior actor)
        {
            _queue.Add(actor);
            _logger.LogToFile($"Клиент {actor.ThisActor.Name} добавлен в очередь");
        }

        /// <summary>
        /// Выход клиентов из магазина.
        /// </summary>
        /// <param name="actors">Список клиентов.</param>
        public void ReleaseFromMarket(List<IActorBehavior> actors)
        {
            foreach (IActorBehavior actor in actors)
            {
                _queue.Remove(actor);
                _logger.LogToFile($"Клиент {actor.ThisActor.Name} ушел из магазина");
            }
        }

        /// <summary>
        /// Обновление состояния магазина.
        /// </summary>
        public void Update()
        {
            TakeOrder();
            GiveOrder();
            ReleaseFromQueue();
        }

        /// <summary>
        /// Выдача заказов клиентам.
        /// </summary>
        public void GiveOrder()
        {
            foreach (IActorBehavior actor in _queue)
            {
                if (actor.IsMakeOrder)
                {
                    actor.IsTakeOrder = true;
                    _logger.LogToFile($"Клиент {actor.ThisActor.Name} получил свой заказ");
                }
            }
        }

        /// <summary>
        /// Освобождение клиентов из очереди.
        /// </summary>
        public void ReleaseFromQueue()
        {
            List<IActorBehavior> releaseActors = new();
            foreach (IActorBehavior actor in _queue)
            {
                if (actor.IsTakeOrder)
                {
                    releaseActors.Add(actor);
                    _logger.LogToFile($"Клиент {actor.ThisActor.Name} ушел из очереди ");
                }
            }
            ReleaseFromMarket(releaseActors);
        }

        /// <summary>
        /// Принятие заказов от клиентов.
        /// </summary>
        public void TakeOrder()
        {
            foreach (IActorBehavior actor in _queue)
            {
                if (!actor.IsMakeOrder)
                {
                    actor.IsMakeOrder = true;
                    if (actor is PromotionalClient pc)
                    {
                        if (CheckPromotion(pc))
                        {
                            _logger.LogToFile($"Клиент {pc.ThisActor.Name} сделал заказ по акции \"{pc.PromotionName}\"");
                            continue;
                        }
                        else
                        {
                            _logger.LogToFile($"Клиенту {actor.ThisActor.Name} отказано в участии в акции \"{pc.PromotionName}\"");
                        }
                    }
                    _logger.LogToFile($"{actor.ThisActor.Name} клиент сделал заказ");
                }
            }
        }

        /// <summary>
        /// Обработка заявки на возврат товара.
        /// </summary>
        /// <param name="actor">Клиент.</param>
        public void HandleReturnOrder(Actor client)
        {
            if (client.ReturnOrderedItem(out decimal refundAmount) && client.RefundMoney(refundAmount))
                _logger.LogToFile($"Клиент {client.Name} возвратил товар и получил сумму: {refundAmount}");
            else
                _logger.LogToFile($"Клиенту {client.Name} отказано в возврате товара");
        }

        /// <summary>
        /// Проверка условий участия в акции
        /// </summary>
        /// <param name="promotionalClient">Акционный клиент.</param>
        private bool CheckPromotion(PromotionalClient promotionalClient) => 
            promotionalClient.ClientId <= _promotions[promotionalClient.PromotionName];
    }
}
