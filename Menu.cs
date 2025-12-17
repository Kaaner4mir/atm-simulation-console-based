class Menu
{

    public static void MainMenu()
    {
        var langManager = new LanguageManager();

        var mainMenuItems = new (string text, ConsoleColor Color)[]
        {
            ( $"{"".PadLeft(6)}📝 Main Menu", ConsoleColor.Red),
            ( $"{new string('-',26)}",ConsoleColor.Gray),
            ( $" 1. {langManager.T("Withdraw")}", ConsoleColor.White),
            ( $" 2. {langManager.T("Deposit")}", ConsoleColor.White),
            ( $" 3. {langManager.T("BalanceInquiry")}", ConsoleColor.White),
            ( $" 4. {langManager.T("MoneyTransfer")}", ConsoleColor.White),
            ( $" 5. {langManager.T("TransactionHistory")}", ConsoleColor.White),
            ( $" 6. {langManager.T("Exit")}", ConsoleColor.White),
        };

        foreach (var item in mainMenuItems)
        {
            Utils.WriteColored(item.text, item.Color);
        }
    }
}