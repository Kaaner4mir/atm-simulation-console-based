using System.Security.Principal;

class MoneyTransfer
{
    static LanguageManager _lm = new LanguageManager();

    public static void Transfer()
    {
        Console.Clear();
        Menu.TransferMenu();

        short inputVal = Utils.GetInput<short>($"{_lm.T("GetInputMain")}");

        switch (inputVal)
        {
            case 1:AnotherAccount(); break;
            case 2:BetweenAccounts(); break;
            default: Utils.WriteColored($"{_lm.T("InvalidOperation")}", ConsoleColor.Red); break;
        }
    }

    public static void AnotherAccount()
    {
        Console.Clear();
        List.ListForeignAccount();

        int foreignId = Utils.GetInput<int>($"{_lm.T("TransferId")}");

        var foreignAccount = Data._foreignaccounts.FirstOrDefault(x => x.AccountId == foreignId);

        if (foreignAccount == null)
        {
            Utils.WriteColored($"{_lm.T("AccountNotFound")}",ConsoleColor.DarkRed);
            return;
        }

        Console.Clear();
        List.ListNonTermAccount();

        int senderId = Utils.GetInput<int>($"{_lm.T("SenderId")}");

        var SenderAccount  = Data._accounts.FirstOrDefault(x => x.AccountId == senderId);

        if (SenderAccount == null)
        {
            Utils.WriteColored($"{_lm.T("AccountNotFound")}", ConsoleColor.DarkRed);
            return;
        }

        decimal transferAmount = Utils.GetInput<decimal>($"{_lm.T("TransferAmount")}");

        if (transferAmount < 10)
        {
            Utils.WriteColored($"{_lm.T("MinTransferAmount")}",ConsoleColor.DarkRed);
            return;
        }

        if (transferAmount > SenderAccount.Balance)
        {
            Utils.WriteColored($"{_lm.T("InsufficientBalance")}", ConsoleColor.DarkRed);
            return;
        }

        SenderAccount.Balance -= transferAmount;

        Console.Clear();

        string resultMessage = string.Format(
            _lm.T("ResultTransfer"),
            SenderAccount.Currency,
            transferAmount,
            SenderAccount.Balance
        );

        Utils.WriteColored(resultMessage, ConsoleColor.Green);

        Logger.AddLog("Transfer", transferAmount);
    }

    public static void BetweenAccounts()
    {
        Console.Clear();
        List.ListNonTermAccount();

        int recieverId = Utils.GetInput<int>($"{_lm.T("RecieverId")}");

        var recieverAccount = Data._accounts.FirstOrDefault(x => x.AccountId == recieverId);

        if (recieverAccount == null)
        {
            Utils.WriteColored($"{_lm.T("AccountNotFound")}", ConsoleColor.DarkRed);
            return;
        }

        Console.Clear();
        List.ListNonTermAccount();

        int senderId = Utils.GetInput<int>($"{_lm.T("SenderId")}");

        var SenderAccount = Data._accounts.FirstOrDefault(x => x.AccountId == senderId);

        if (SenderAccount == null)
        {
            Utils.WriteColored($"{_lm.T("AccountNotFound")}", ConsoleColor.DarkRed);
            return;
        }

        decimal transferAmount = Utils.GetInput<decimal>($"{_lm.T("TransferAmount")}");

        if (transferAmount < 10)
        {
            Utils.WriteColored($"{_lm.T("MinTransferAmount")}", ConsoleColor.DarkRed);
            return;
        }

        if (transferAmount > SenderAccount.Balance)
        {
            Utils.WriteColored($"{_lm.T("InsufficientBalance")}", ConsoleColor.DarkRed);
            return;
        }

        SenderAccount.Balance -= transferAmount;

        Console.Clear();

        string resultMessage = string.Format(
            _lm.T("ResultTransfer"),
            SenderAccount.Currency,
            transferAmount,
            SenderAccount.Balance
        );

        Utils.WriteColored(resultMessage, ConsoleColor.Green);

        Logger.AddLog("Transfer", transferAmount);
    }
}