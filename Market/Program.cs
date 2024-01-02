using Market.Classes;
using Market.Services;

Logger logger = new("mart_log.txt");
string promotionName = "Рождественская распродажа";
Dictionary<string, int> promotions = new() { [promotionName] = 2 };
Shop magnit = new(logger, promotions);

Actor client1 = new PromotionalClient("boris", promotionName);
Actor client2 = new PromotionalClient("masha", promotionName);
Actor client3 = new SpecialClient("prezident", 1);
TaxInspector client4 = new();
Actor client5 = new PromotionalClient("kolya", promotionName);
Actor client6 = new PromotionalClient("denis", promotionName);


magnit.AcceptToMarket(client1);
magnit.AcceptToMarket(client2);
magnit.AcceptToMarket(client3);
magnit.AcceptToMarket(client4);
magnit.AcceptToMarket(client5);
magnit.AcceptToMarket(client6);

magnit.Update();

magnit.HandleReturnOrder(client1);
magnit.HandleReturnOrder(client2);
magnit.HandleReturnOrder(client3);