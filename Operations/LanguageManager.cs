public class LanguageManager
{
    public enum Language
    {
        TR,
        EN
    }

    private static Language _selectedLanguage = Language.TR;

    private static readonly Dictionary<string, string> TR = new()
    {
        // Main Menu
        { "MainMenu", "📝 Ana Menü" },
        { "Withdraw", "Para Çekme" },
        { "Deposit", "Para Yatırma" },
        { "BalanceInquiry", "Bakiye Sorgulama" },
        { "MoneyTransfer", "Para Transferi" },
        { "Payments", "Ödemeler" },
        { "TransactionHistory", "Hesap Hareketleri" },
        { "Exit", "Çıkış" },

        // List
        { "Id", " 🔑 Hesap ID     :" },
        { "Name", " 🏷️ Hesap Adı    :" },
        { "Branch", " 🏦 Şube         :" },
        { "OpeningDate", " 📆 Açılış Tarihi:" },
        { "Currency", " 💱 Para Birimi  :" },
        { "Balance", " 💰 Bakiye       :" },

        // Withdraw Menu
        { "WishWithdraw", "\n 👉 Lütfen para çekmek istediğiniz hesabın numarasını giriniz: " },
        { "AmountWithdraw", "\n ➡️ Lütfen hesabınızdan çekmek istediğiniz tutarı giriniz: " },
        { "MinWithdrawAmount", "\n ❌ En az €10 çekebilirsiniz." },
        { "InsufficientBalance", "\n ❌ Yetersiz bakiye!" },
        { "ResultWithdraw", " ✅ Hesabınızdan başarılı bir şekilde {0}{1} çekildi. Yeni bakiye: {0}{2}" },

        // Deposit Menu
        { "WishDeposit", "\n 👉 Lütfen para yatırmak istediğiniz hesabın numarasını giriniz: " },
        { "AmountDeposit", "\n ➡️ Lütfen hesabınıza yatırmak istediğiniz tutarı giriniz: " },
        { "MinDepositAmount", "\n ❌ En az €10 yatırabilirsiniz." },
        { "ResultDeposit", " ✅ Hesabınıza başarılı bir şekilde {0}{1} yatırıldı. Yeni bakiye: {0}{2}" },

        // Transfer Menu
        { "TransferMenu", "📲 Transfer Menüsü" },
        { "TransferWithAccountNumber", "Hesap numarası ile transfer" },
        { "BetweenMyAccounts", "Kendi hesaplarım arasında transfer" },
        { "TransferId", "\n ➡️ Para göndermek istediğiniz hesabın numarasını giriniz: " },
        { "SenderId", "\n ➡️ Gönderen hesaba ait hesap numarasını giriniz: " },
        { "TransferAmount", "\n ➡️ Göndermek istediğiniz tutarı giriniz: " },
        { "MinTransferAmount", "\n ❌ Gönderebileceğiniz minimum tutar €10'dur." },
        { "ResultTransfer", " ✅ {0}{1} başarıyla transfer edildi. Yeni bakiye: {0}{2}" },
        { "RecieverId", "\n ➡️ Alıcı hesaba ait hesap numarasını giriniz: " },

        // Exceptions and Errors
        { "AccountNotFound", "\n ❓ Hesap bulunamadı!" },
        { "Catch", "\n ⛔ Bir hata oluştu: {0}" },
        { "InvalidOperation", "\n ❓ Yapmak istediğiniz işlem geçersizdir!" },

        // General
        { "SelectLanguage", "Dil Seçimi" },
        { "EnterChoice", "Seçiminizi giriniz" },
        { "GetInputMain", "\n 👉 Gerçekleştirmek istediğiniz işlemi numerik olarak giriniz: " }
    };

    private static readonly Dictionary<string, string> EN = new()
    {
        // Main Menu
        { "MainMenu", "📝 Main Menu" },
        { "Withdraw", "Withdraw Money" },
        { "Deposit", "Deposit Money" },
        { "BalanceInquiry", "Balance Inquiry" },
        { "MoneyTransfer", "Money Transfer" },
        { "Payments", "Bill Payment" },
        { "TransactionHistory", "Transaction History" },
        { "Exit", "Exit" },

        // List
        { "Id", " 🔑 Account ID   :" },
        { "Name", " 🏷️ Account Name :" },
        { "Branch", " 🏦 Branch       :" },
        { "OpeningDate", " 📆 Opening Date :" },
        { "Currency", " 💱 Currency     :" },
        { "Balance", " 💰 Balance      :" },

        // Withdraw Menu
        { "WishWithdraw", "\n 👉 Please enter the ID of the account you wish to withdraw money from: " },
        { "AmountWithdraw", "\n ➡️ Enter the amount you want to withdraw from the account: " },
        { "MinWithdrawAmount", "\n ❌ The minimum amount you can withdraw is €10." },
        { "InsufficientBalance", "\n ❌ Insufficient balance!" },
        { "ResultWithdraw", " ✅ {0}{1} has been successfully withdrawn from your account. New balance: {0}{2}" },

        // Deposit Menu
        { "WishDeposit", "\n 👉 Please enter the ID of the account you wish to deposit money into: " },
        { "AmountDeposit", "\n ➡️ Enter the amount you want to deposit into account: " },
        { "MinDepositAmount", "\n ❌ The minimum amount you can deposit is €10." },
        { "ResultDeposit", " ✅ {0}{1} has been successfully deposited into your account. New balance: {0}{2}" },

        // Transfer Menu
        { "TransferMenu", "📲 Transfer Menu" },
        { "TransferWithAccountNumber", "Transfer with account number" },
        { "BetweenMyAccounts", "Between My Accounts" },
        { "TransferId", "\n ➡️ Please enter the account number of the account to which you wish to transfer money: " },
        { "SenderId", "\n ➡️ Please enter the account number associated with the sender's account: " },
        { "TransferAmount", "\n ➡️ Enter the amount you wish to send: " },
        { "MinTransferAmount", "\n ❌ The minimum amount you can send is €10." },
        { "ResultTransfer", " ✅ {0}{1} has been successfully transferred. New Balance: {0}{2}" },
        { "RecieverId", "\n ➡️ Please enter the account number associated with the recipient's account: " },

        // Exceptions and Errors
        { "AccountNotFound", "\n ❓ Account not found!" },
        { "Catch", "\n ⛔ An error has occurred: {0}" },
        { "InvalidOperation", "\n ❓ The operation you want to perform is invalid!" },

        // General
        { "SelectLanguage", "Select Language" },
        { "EnterChoice", "Enter your choice" },
        { "GetInputMain", "\n 👉 Please enter the operation you wish to perform numerically: " }
    };

    public void SetLanguage(Language lang)
    {
        _selectedLanguage = lang;
    }

    public string T(string key)
    {
        return _selectedLanguage switch
        {
            Language.TR => TR[key],
            Language.EN => EN[key],
            _ => key
        };
    }
}
