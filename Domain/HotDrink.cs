namespace VendingMachine.Domain;
internal class HotDrink(int price, int place, string name, long id, int temperature) : Product(price, place, name, id)
{
    public int Temperature { get; set; } = temperature;
    public override string ToString() => $"""
        {base.ToString().TrimEnd()}
        Temperature = {Temperature}°C

        """;
}
