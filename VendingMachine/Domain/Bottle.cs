namespace VendingMachine.Domain;
internal class Bottle(int price, int place, string name, long id, float bottleVolume) : Product(price, place, name, id)
{
    public float BottleVolume { get; set; } = bottleVolume;
    public override string ToString() => $"""
        {base.ToString().TrimEnd()}
        Volume = {BottleVolume}

        """;
}
