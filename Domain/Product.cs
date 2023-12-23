namespace VendingMachine.Domain;
public class Product(int price, int place, string name, long id)
{
    private int _price = price;

    public int Price 
    {
        get => _price;
        set => _price = value < 0 ? 10 : value;
    }
    public int Place { get; set; } = place;
    public string Name { get; set; } = name;
    public long Id { get; set; } = id;

    public override string ToString() => $"""
        Price = {Price}
        Place = {Place}
        Name = {Name}
        ID = {Id}

        """;
}

