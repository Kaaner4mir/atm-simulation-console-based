class Exit
{
    static LanguageManager _lm = new LanguageManager();

    public static void ExitOperations()
    {
        Console.Clear();

        string inputVal = Utils.GetInput<string>($"{_lm.T("ExitOperation")}");

        if (inputVal.ToUpper() == "Y")
        {
            Environment.Exit(0);
        }
        else if (inputVal.ToUpper() == "N")
        {
            return;
        }
        else
        {
            Utils.WriteColored($"{_lm.T("InvalidOperation")}",ConsoleColor.Red);
        }

    }
}