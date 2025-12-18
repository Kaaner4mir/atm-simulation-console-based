class Depoist
{
    public static void DepositMoney()
    {
        Console.Clear();
        List.ListNonTermAccount();
        LanguageManager lm = new LanguageManager();

        int id = Utils.GetInput<int>($"{lm.T("WishDeposit")}");

        var account = Data._accounts.FirstOrDefault(x => x.AccountId == id);

        if (account == null)
        {
            Utils.WriteColored($"{lm.T("AccountNotFound")}",ConsoleColor.Red);
            return;
        }

        decimal depositAmount = Utils.GetInput<decimal>($"{lm.T("AmountDeposit")}");

        if (depositAmount < 10)
        {
            Utils.WriteColored($"{lm.T("MinDepositAmount")}", ConsoleColor.Red);
            return;
        }

        account.Balance += depositAmount;

        Console.Clear();

        string resultMessage = string.Format(
            lm.T("ResultDeposit"),
            account.Currency,
            depositAmount,
            account.Balance
        );

        Utils.WriteColored(resultMessage, ConsoleColor.Green);

        Logger.AddLog("Deposit", depositAmount);

    }
}