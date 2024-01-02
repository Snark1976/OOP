using VendingMachine.Domain;
using VendingMachine.Services;

Holder hold = new();
CoinDispenser coin = new();
Display display = new();
List<Product> listProd =
[
    new(100, 12, "Lays", 1234),
    new(120, 14, "Nuts", 1235),
    new(90, 16, "Chips", 1236),
    new(20, 18, "Milky", 1237),
    new(60, 1, "3korochki", 1238),
    new(150, 2, "Snickers", 1239),
    new Bottle(150, 3, "Cola", 1240, 0.5f),
    new HotDrink(130, 10, "Tea", 1241, 85),
];

VendMachine vm = new(hold, coin, display, listProd);
vm.Assort.ForEach(Console.WriteLine);
