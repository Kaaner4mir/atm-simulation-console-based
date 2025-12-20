class UserControl
{
    static LanguageManager _lm = new LanguageManager();

    const int _password = 1111;
    static short _attempt = 5;

    public static void Control()
    {
        Console.Clear();

        while (_attempt >= 0)
        {
            int password = Utils.GetInput<int>($"{_lm.T("CardPassword")}");

            if (password == _password)
            {
                Utils.WriteColored($"{_lm.T("TruePassword")}", ConsoleColor.Green);
                break;
            }
            else
            {
                string resultMessage = string.Format(_lm.T("WrongPassword"), _attempt);
                Utils.WriteColored(resultMessage, ConsoleColor.Red);
                _attempt--;
            }
            Console.Clear();
        }
        Utils.WaitingScreen();

        if (_attempt == -1)
        {
            Utils.WriteColored($"{_lm.T("Blocked")}");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}