class Withdraw
{
    public static void WithdrawMoney()
    {
        Console.Clear();
        List.ListNonTermAccount();

        int id = Utils.GetInput<int>("\n 👉 Please enter the ID of the account you wish to withdraw money from: ");

        var account = Data._accounts.FirstOrDefault(x => x.AccountId == id);

        if (account == null)
        {
            Utils.WriteColored("\n ❓ Account not found!");
            return;
        }

        decimal withdrawAmount = Utils.GetInput<decimal>("\n ➡️ Enter the amount you want to withdraw from account: ");

        if (withdrawAmount < 10)
        {
            Utils.WriteColored("\n ❌ The minimum amount you can withdraw is €10.", ConsoleColor.Red);
            return;
        }

        if (withdrawAmount > account.Balance)
        {
            Utils.WriteColored("\n ❌ Insufficient balance!",ConsoleColor.Red);
            return;
        }

        account.Balance -= withdrawAmount;

        Console.Clear();

        Utils.WriteColored($" ✅ {account.Currency}{withdrawAmount} has been successfully withdrawn from your account. New balance: {account.Balance}",ConsoleColor.Green);

        Logger.AddLog("Withdraw",withdrawAmount);

    }
}