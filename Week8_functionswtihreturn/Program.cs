
string[] tvshows = { "firefly", "friends", "office", "Twin peaks", "House", "stranger things" };
string[] food = { "sushi", "pizza", "burger", "fish and chips", "chiken wings", "popcorn" };
string[] drinks = { "mineral water", "coca-cola", "apple juice", "milk", "wine" };

//Random rnd = new Random();

//int randomindex = rnd.Next(tvshows.Length);
////Console.WriteLine(randomindex);
//string randommovie = tvshows[randomindex];  
//Console.WriteLine(randommovie);

//randomindex = rnd.Next(0,food.Length);
//string randomfood = food[randomindex];
//Console.WriteLine(randomfood);

//randomindex = rnd.Next(0,drinks.Length);
//string randomdrink = drinks[randomindex];
//Console.WriteLine(randomdrink);

string randommovie = pickrandomfromarray(tvshows);
string randomfood = pickrandomfromarray(food);
string randomdrink = pickrandomfromarray(drinks);

Console.WriteLine($"I recommend you to watch {randommovie} tonight.");
Console.WriteLine($"Order some {randomfood} and {randomdrink}.");

////pickrandomfromarray(tvshows);
////pickrandomfromarray(food);
////pickrandomfromarray(drinks);

static string pickrandomfromarray(string[] somearray)
{
    Random random = new Random();

    int randomindex = random.Next(0, somearray.Length);
    string randomelement = somearray[randomindex];
    Console.WriteLine(randomelement);
    return randomelement;
}


