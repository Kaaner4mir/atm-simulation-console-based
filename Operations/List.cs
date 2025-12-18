class List
{
   static LanguageManager lm = new LanguageManager();

    public static void ListNonTermAccount()
    {
        foreach (var item in Data._accounts)
        {
            Utils.WriteColored($"{lm.T("Id")} {item.AccountId}", ConsoleColor.DarkYellow);
            Utils.WriteColored($"{lm.T("Name")} {item.AccountName}", ConsoleColor.DarkYellow);
            Utils.WriteColored($"{lm.T("Branch")} {item.Branch}", ConsoleColor.DarkGray);
            Utils.WriteColored($"{lm.T("OpeningDate")} {item.OpeningDate}", ConsoleColor.DarkCyan);
            Utils.WriteColored($"{lm.T("Currency")} {item.Currency}", ConsoleColor.White);
            Utils.WriteColored($"{lm.T("Balance")} {item.Currency}{item.Balance}", ConsoleColor.Green);
            Utils.WriteColored($"{new string('-', 50)}", ConsoleColor.White);
        }
    }

    public static void ListForeignAccount()
    {
        foreach (var item in Data._foreignaccounts)
        {
            Utils.WriteColored($"{lm.T("Id")} {item.AccountId}", ConsoleColor.DarkYellow);
            Utils.WriteColored($"{lm.T("Name")} {item.Branch}", ConsoleColor.DarkYellow);
            Utils.WriteColored($"{lm.T("Currency")} {item.Currency}", ConsoleColor.White);
            Utils.WriteColored($"{new string('-', 50)}", ConsoleColor.White);
        }
    }
}