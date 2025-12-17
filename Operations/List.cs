class List
{
    public static void ListNonTermAccount()
    {
        Console.Clear();

        foreach (var item in Data._accounts)
        {
            Utils.WriteColored($" 🔑 Account ID  : {item.AccountId}",ConsoleColor.Yellow);
            Utils.WriteColored($" 🏷️ Account Name: {item.AccountName}",ConsoleColor.White);
            Utils.WriteColored($" 📆 Opening Date: {item.OpeningDate}",ConsoleColor.DarkCyan);
            Utils.WriteColored($" 💱 Currency    : {item.Currency}",ConsoleColor.Gray);
            Utils.WriteColored($" 💰 Balance     : {item.Currency}{item.Balance}",ConsoleColor.Green);
            Utils.WriteColored($"{new string('-',50)}",ConsoleColor.White);
        }
    }
}