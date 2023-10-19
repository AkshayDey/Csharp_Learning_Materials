using UpdateDictionaryValueExample;


var toppingsDictionary = new ToppingsDictionary();
//toppingsDictionary.AddToppings("pepperoni", 4);

//try
//{
//    toppingsDictionary.Toppings["jalepeno"] = toppingsDictionary.Toppings["jalepeno"] + 1;
//}
//catch (Exception e)
//{
//    Console.WriteLine(e);
//}

//toppingsDictionary.AddToppings("jalepeno", 1);

//foreach (var topping in toppingsDictionary.Toppings)
//{
//    Console.WriteLine($"{topping.Key} = {topping.Value}");
//}

foreach(var allItems in toppingsDictionary.Toppings)
{
    Console.WriteLine($"Key is  {allItems.Key}, value is  {allItems.Value}");
}