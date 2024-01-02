using VendingMachine.Domain;

namespace VendingMachine.Services;
internal class VendMachine(Holder hold, CoinDispenser coin, Display display, List<Product> assort)
{
    public Holder Hold { get; set; } = hold;
    public CoinDispenser Coin { get; set; } = coin;
    public Display Display { get; set; } = display;
    public List<Product> Assort { get; set; } = assort;
}
