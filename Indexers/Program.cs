using Indexers;

ShoppingCart cart = new ShoppingCart();
cart.AddItem(new Item() { Name = "Camera", Price = 4500 });
cart.AddItem(new Item() { Name = "Keyboard", Price = 3000 });

var firstIndex = cart[0];
