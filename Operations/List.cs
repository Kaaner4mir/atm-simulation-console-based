class List
{
   static LanguageManager lm = new LanguageManager();

    public static void ListNonTermAccount()
    {
        foreach (var item in Data._accounts)
        {
            Utils.WriteColored($"{lm.T("Id").PadRight(25)}: {item.AccountId}", ConsoleColor.DarkYellow);
            Utils.WriteColored($"{lm.T("Name").PadRight(26)}: {item.AccountName}", ConsoleColor.DarkYellow);
            Utils.WriteColored($"{lm.T("Branch").PadRight(25)}: {item.Branch}", ConsoleColor.DarkGray);
            Utils.WriteColored($"{lm.T("OpeningDate").PadRight(25)}: {item.OpeningDate}", ConsoleColor.DarkCyan);
            Utils.WriteColored($"{lm.T("Currency").PadRight(25)}: {item.Currency}", ConsoleColor.White);
            Utils.WriteColored($"{lm.T("Balance").PadRight(25)}: {item.Currency}{item.Balance}", ConsoleColor.Green);
            Utils.WriteColored($"{new string('-', 50)}", ConsoleColor.White);
        }
    }

    public static void ListForeignAccount()
    {
        foreach (var item in Data._foreignaccounts)
        {
            Utils.WriteColored($"{lm.T("Id").PadRight(25)}: {item.AccountId}", ConsoleColor.DarkYellow);
            Utils.WriteColored($"{lm.T("Name").PadRight(26)}: {item.Branch}", ConsoleColor.DarkYellow);
            Utils.WriteColored($"{lm.T("Currency").PadRight(25)}: {item.Currency}", ConsoleColor.White);
            Utils.WriteColored($"{new string('-', 50)}", ConsoleColor.White);
        }
    }
}