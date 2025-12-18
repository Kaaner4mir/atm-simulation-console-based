using System.Text;

class Initializer
{
    static LanguageManager _lm = new LanguageManager();

    public static async Task Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "🏦 Automated Teller Machine";

        try
        {
            ChooseLanguage();

            while (true)
            {
                Console.Clear();
                Menu.MainMenu();

                short inputVal = Utils.GetInput<short>($"{_lm.T("GetInputMain")}");

                switch (inputVal)
                {
                    case 1: Withdraw.WithdrawMoney(); break;
                    case 2: Depoist.DepositMoney(); break;
                    case 3: BalanceInquiry.ListAccounts(); break;
                    case 4: MoneyTransfer.Transfer(); break;
                    default: Utils.WriteColored($"{_lm.T("InvalidOperation")}", ConsoleColor.Red); break;
                }
                Utils.WaitingScreen();
                await Animations.SpinnerAnimation();
            }
        }
        catch (Exception ex)
        {
            Utils.WriteColored(string.Format(_lm.T("Catch"), ex.Message), ConsoleColor.Red);
        }
    }

    public static void ChooseLanguage()
    {
        var lm = new LanguageManager();

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
                    lm.SetLanguage(LanguageManager.Language.TR);
                    return;

                case '2':
                    lm.SetLanguage(LanguageManager.Language.EN);
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
