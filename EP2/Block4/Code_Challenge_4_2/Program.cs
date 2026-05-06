using Code_Challenge_4_2;

var inventory = new Inventory(3);

var sword = new Item("Sword", 3.5f);
var potion = new Item("Potion", 2.0f);
var shield = new Item("Shield", 5.0f);
var helmet = new Item("Helmet", 1.5f);

inventory.AddItem(sword);
inventory.AddItem(potion);

Console.WriteLine(inventory.ItemCount); // Prints 2
Console.WriteLine(inventory.CurrentWeight); // Prints 5.5

inventory.AddItem(shield);
Console.WriteLine(inventory.AddItem(helmet)); // Prints False

Console.WriteLine(inventory.RemoveItem("Potion")); // Prints True
Console.WriteLine(inventory.RemoveItem("Potion")); // Prints False

inventory.PrintInventory();
// Prints:
/*

Capacity: 3
Items: 2
Total Weight: 8,5
Items:
1. Sword (Weight: 3,5)
2. Shield (Weight: 5)

*/