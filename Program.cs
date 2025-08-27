string bröd, fordon, destination;
Console.WriteLine("säg ditt favorit fikabröd");
bröd = Console.ReadLine();

Console.WriteLine("säg din favorit offentliga transportation");
fordon = Console.ReadLine();

Console.WriteLine("var är din favoritplats?");
destination = Console.ReadLine();

Console.WriteLine($"du ska åka {bröd}{fordon} till {destination}");

Console.ReadLine();