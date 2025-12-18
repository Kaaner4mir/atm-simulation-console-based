class Withdraw
{

    static LanguageManager _lm = new LanguageManager();
    public static void WithdrawMoney()
    {
        Console.Clear();
        List.ListNonTermAccount();

        int id = Utils.GetInput<int>($"{_lm.T("WishWithdraw")}");

        var account = Data._accounts.FirstOrDefault(x => x.AccountId == id);

        if (account == null)
        {
            Utils.WriteColored($"{_lm.T("AccountNotFound")}",ConsoleColor.Red);
            return;
        }

        decimal withdrawAmount = Utils.GetInput<decimal>($"{_lm.T("AmountWithdraw")}");

        if (withdrawAmount < 10)
        {
            Utils.WriteColored($"{_lm.T("MinWithdrawAmount")}", ConsoleColor.Red);
            return;
        }

        if (withdrawAmount > account.Balance)
        {
            Utils.WriteColored($"{_lm.T("InsufficientBalance")}", ConsoleColor.Red);
            return;
        }

        account.Balance -= withdrawAmount;

        Console.Clear();

        string resultMessage = string.Format(
            _lm.T("ResultWithdraw"),
            account.Currency,
            withdrawAmount,
            account.Balance
        );

        Utils.WriteColored(resultMessage, ConsoleColor.Green);

        Logger.AddLog("Withdraw", withdrawAmount);


    }
}