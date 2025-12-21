class LogHistory
{
    static LanguageManager _lm = new LanguageManager();

    public static void ListLog()
    {
        Console.Clear();

        foreach (var item in Data._logs)
        {
            Utils.WriteColored($"{_lm.T("LogId").PadRight(25)}: {item.LogId}", ConsoleColor.DarkYellow);
            Utils.WriteColored($"{_lm.T("LogTime").PadRight(24)}: {item.Time}", ConsoleColor.White);
            Utils.WriteColored($"{_lm.T("Type").PadRight(25)}: {item.Type}", ConsoleColor.DarkBlue);
            Utils.WriteColored($"{_lm.T("LogTransactionAmount").PadRight(25)}: €{item.TransactionAmount}", ConsoleColor.Green);
            Utils.WriteColored($"{new string('-', 50)}", ConsoleColor.White);
        }
    }
}