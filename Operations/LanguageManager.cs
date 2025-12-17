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
        { "Withdraw", "Para Çekme" },
        { "Deposit", "Para Yatırma" },
        { "BalanceInquiry", "Bakiye Sorgulama" },
        { "MoneyTransfer", "Para Transferi" },
        { "Payments", "Ödemeler" },
        { "TransactionHistory", "Hesap Hareketleri" },
        { "Exit", "Çıkış" },
        { "SelectLanguage", "Dil Seçimi" },
        { "EnterChoice", "Seçiminizi giriniz" }
    };

    private static readonly Dictionary<string, string> EN = new()
    {
        { "Withdraw", "Withdraw Money" },
        { "Deposit", "Deposit Money" },
        { "BalanceInquiry", "Balance Inquiry" },
        { "MoneyTransfer", "Money Transfer" },
        { "Payments", "Bill Payment" },
        { "TransactionHistory", "Transaction History" },
        { "Exit", "Exit" },
        { "SelectLanguage", "Select Language" },
        { "EnterChoice", "Enter your choice" }
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
