using System.Text;
using System.Threading.Tasks;

class Initializer
{
    public static async Task Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "🏦 Automated Teller Machine";

        try
        {
            // ChooseLanguage();

            while (true)
            {
                Console.Clear();
                Menu.MainMenu();

                short inputVal = Utils.GetInput<short>("\n 👉 Please enter the operation you wish to perform numerically: ");

                switch (inputVal)
                {
                    case 1: Withdraw.WithdrawMoney(); break;
                    case 2: Depoist.DepositMoney(); break;
                    case 3: List.ListNonTermAccount(); break;

                    default: Utils.WriteColored("\n ❓ The operation you want to perform is invalid!"); break;
                }
                Utils.WaitingScreen();
                await Animations.SpinnerAnimation();
            }
        }
        catch (Exception ex)
        {
            Utils.WriteColored($"\n ⛔ An error has occured: {ex.Message}", ConsoleColor.Red);
        }
    }

    private static void ChooseLanguage()
    {
        var langManager = new LanguageManager();

        while (true)
        {
            Console.Clear();

            Console.CursorVisible = false;
            Utils.WriteColored(" 1. Türkçe");
            Utils.WriteColored(" 2. English");

            char choice = Console.ReadKey(true).KeyChar;

            switch (choice)
            {
                case '1':
                    langManager.SetLanguage(LanguageManager.Language.TR);
                    return;

                case '2':
                    langManager.SetLanguage(LanguageManager.Language.EN);
                    return;

                default:
                    Utils.WriteColored("\n ⚠️ Invalid Transaction! Please try again.", ConsoleColor.Yellow);
                    Thread.Sleep(800);
                    break;
            }
            Console.CursorVisible = true;
        }
    }

}
