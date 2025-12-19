class LogHistory
{
    static LanguageManager _lm = new LanguageManager();

    public static void ListLog()
    {
        Console.Clear();

        foreach (var item in Data._logs)
        {
            Utils.WriteColored($"{_lm.T("LogId")} {item.LogId}", ConsoleColor.DarkYellow);
            Utils.WriteColored($"{_lm.T("LogTime")} {item.Time}", ConsoleColor.White);
            Utils.WriteColored($"{_lm.T("Type")} {item.Type}", ConsoleColor.DarkBlue);
            Utils.WriteColored($"{_lm.T("LogTransactionAmount")}€{item.TransactionAmount}", ConsoleColor.Green);
            Utils.WriteColored($"{new string('-', 50)}", ConsoleColor.White);
        }
    }
}