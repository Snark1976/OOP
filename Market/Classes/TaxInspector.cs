using Market.Interfaces;

namespace Market.Classes;

/// <summary>
/// Класс, представляющий налогового инспектора.
/// </summary>
internal class TaxInspector : IActorBehavior
{
    /// <summary>
    /// Имя налогового инспектора.
    /// </summary>
    public string Name { get; } = "Tax audit";

    /// <summary>
    /// Поле, указывающее, взял ли заказ налоговый инспектор.
    /// </summary>
    public bool IsTakeOrder { get; set; }

    /// <summary>
    /// Поле, указывающее, сделал ли налоговый инспектор заказ.
    /// </summary>
    public bool IsMakeOrder { get; set; }

    /// <summary>
    /// Экземпляр налогового инспектора.
    /// </summary>
    public Actor ThisActor => new OrdinaryClient(Name);
}
