class Menu
{
    static LanguageManager _lm = new LanguageManager();

    public static void MainMenu()
    {
        var mainMenuItems = new (string text, ConsoleColor Color)[]
        {
            ( $"{"".PadLeft(6)}{_lm.T("MainMenu")}",ConsoleColor.White),
            ( $" {new string('-',23)}",ConsoleColor.Gray),
            ( $" 1. {_lm.T("Withdraw")}", ConsoleColor.DarkRed),
            ( $" 2. {_lm.T("Deposit")}", ConsoleColor.Green),
            ( $" 3. {_lm.T("BalanceInquiry")}", ConsoleColor.Blue),
            ( $" 4. {_lm.T("MoneyTransfer")}", ConsoleColor.DarkYellow),
            ( $" 6. {_lm.T("TransactionHistory")}", ConsoleColor.White),
            ( $" 7. {_lm.T("Exit")}", ConsoleColor.Magenta),
        };

        foreach (var item in mainMenuItems)
        {
            Utils.WriteColored(item.text, item.Color);
        }
    }

    public static void TransferMenu()
    {
        var mainMenuItems = new (string text, ConsoleColor Color)[]
        {
            ( $"{"".PadLeft(6)}{_lm.T("TransferMenu")}",ConsoleColor.White),
            ( $" {new string('-',23)}",ConsoleColor.Gray),
            ( $" 1. {_lm.T("TransferWithAccountNumber")}", ConsoleColor.Blue),
            ( $" 2. {_lm.T("BetweenMyAccounts")}", ConsoleColor.Green),
        };

        foreach (var item in mainMenuItems)
        {
            Utils.WriteColored(item.text, item.Color);
        }
    }


}