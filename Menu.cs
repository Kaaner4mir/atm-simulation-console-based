class Menu
{
    
    public static void MainMenu()
    {
        var langManager = new LanguageManager();

        var mainMenuItems = new (string text, ConsoleColor Color)[]
        {
            ( $"{"".PadLeft(6)}📝 Main Menu", ConsoleColor.Magenta),
            ( $"{new string('-',26)}",ConsoleColor.White),
            ( $" 1. {langManager.T("Withdraw")}", ConsoleColor.Blue),
            ( $" 2. {langManager.T("Deposit")}", ConsoleColor.Blue),
            ( " 1. Balance Inquiry", ConsoleColor.Blue),
            ( " 1. Money Transfer", ConsoleColor.Blue),
            ( " 1. Payment Transactions", ConsoleColor.Blue),
            ( " 1. Transaction History", ConsoleColor.Blue),
            ( " 1. Exit", ConsoleColor.Blue),
        };

        foreach (var item in mainMenuItems)
        {
            Utils.WriteColored(item.text, item.Color);
        }
    }
}