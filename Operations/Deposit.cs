class Depoist
{
    public static void DepositMoney()
    {
        Console.Clear();
        List.ListNonTermAccount();

        int id = Utils.GetInput<int>("\n 👉 Please enter the ID of the account you wish to deposit money into: ");

        var account = Data._accounts.FirstOrDefault(x => x.AccountId == id);

        if (account == null)
        {
            Utils.WriteColored("\n ❓ Account not found!");
            return;
        }

        decimal depositAmount = Utils.GetInput<decimal>("\n ➡️ Enter the amount you want to deposit into account: ");

        if (depositAmount < 10)
        {
            Utils.WriteColored("\n ❌ The minimum amount you can deposit is €10.", ConsoleColor.Red);
            return;
        }

        account.Balance += depositAmount;

        Console.Clear();

        Utils.WriteColored($" ✅ {account.Currency}{depositAmount} has been successfully deposited into your account. New balance: {account.Balance}", ConsoleColor.Green);

        Logger.AddLog("Deposit", depositAmount);

    }
}