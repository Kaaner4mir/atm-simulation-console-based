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
            UserControl.Control();
            await Animations.SpinnerAnimation();

            while (true)
            {
                Console.Clear();
                Menu.MainMenu();

                short inputVal = Utils.GetInput<short>($"{_lm.T("GetInputMain")}");

                switch (inputVal)
                {
                    case 1: Withdraw.WithdrawMoney(); break;
                    case 2: Deposit.DepositMoney(); break;
                    case 3: BalanceInquiry.ListAccounts(); break;
                    case 4: MoneyTransfer.Transfer(); break;
                    case 5: LogHistory.ListLog(); break;
                    case 6: Exit.ExitOperations(); break;
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
        while (true)
        {
            Console.Clear();

            Console.CursorVisible = false;
            Utils.WriteColored(" 1. Türkçe");
            Utils.WriteColored(" 2. English");
            Utils.WriteColored(" 3. Deutsch");
            Utils.WriteColored(" 4. Français");
            Utils.WriteColored(" 5. Español");
            Utils.WriteColored(" 6. Italiano");
            Utils.WriteColored(" 7. Русский");

            char choice = Console.ReadKey(true).KeyChar;

            switch (choice)
            {
                case '1':
                    _lm.SetLanguage(LanguageManager.Language.TR);
                    return;

                case '2':
                    _lm.SetLanguage(LanguageManager.Language.EN);
                    return;

                case '3':
                    _lm.SetLanguage(LanguageManager.Language.DE);
                    return;

                case '4':
                    _lm.SetLanguage(LanguageManager.Language.FR);
                    return;

                case '5':
                    _lm.SetLanguage(LanguageManager.Language.ES);
                    return;

                case '6':
                    _lm.SetLanguage(LanguageManager.Language.IT);
                    return;

                case '7':
                    _lm.SetLanguage(LanguageManager.Language.RU);
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
