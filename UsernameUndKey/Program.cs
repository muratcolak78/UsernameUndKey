Console.WriteLine("\nUsername: ");
string username = "";
ConsoleKeyInfo key;
do
{
    string symbol = "";
    key = Console.ReadKey(true); 

    
    if (key.Key != ConsoleKey.Enter)
    {
        username += key.KeyChar;
        symbol = "*";
        Console.Write(symbol);
    }
} while (key.Key != ConsoleKey.Enter);

Console.WriteLine("\nPassWort: ");
string sifre = "";

do
{
    string symbol = "";
    key = Console.ReadKey(true); 
    
    if (key.Key != ConsoleKey.Enter)
    {
        sifre += key.KeyChar;
        symbol = "*";
        Console.Write(symbol);
    }
} while (key.Key != ConsoleKey.Enter);

