public class LanguageManager
{
    public enum Language
    {
        TR,
        EN
    }

    private static readonly Dictionary<string, string> TR = new()
    {
        { "Withdraw", "Para Çekme" },
        { "Deposit", "Para Yatırma" },
        { "Balance", "Bakiye Sorgulama" },
        { "Transfer", "Para Transferi" },
        { "Exit", "Çıkış" },
        { "SelectLanguage", "Dil Seçimi" },
        { "EnterChoice", "Seçiminizi giriniz" }
    };

    private static readonly Dictionary<string, string> EN = new()
    {
        { "Withdraw", "Withdraw Money" },
        { "Deposit", "Deposit Money" },
        { "Balance", "Balance Inquiry" },
        { "Transfer", "Money Transfer" },
        { "Exit", "Exit" },
        { "SelectLanguage", "Select Language" },
        { "EnterChoice", "Enter your choice" }
    };

    public Language SelectedLanguage { get; private set; }

    public LanguageManager(Language defaultLanguage = Language.TR)
    {
        SelectedLanguage = defaultLanguage;
    }

    public void SetLanguage(Language lang)
    {
        SelectedLanguage = lang;
    }

    public string T(string key)
    {
        return SelectedLanguage switch
        {
            Language.TR => TR[key],
            Language.EN => EN[key],
            _ => key
        };
    }
}
