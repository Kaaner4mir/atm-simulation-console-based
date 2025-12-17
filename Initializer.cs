using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "🏦 Automated Teller Machine";

        try
        {
            ChooseLanguage();

            while (true)
            {
                Console.Clear();
                Menu.MainMenu();
                Console.ReadKey();
            }
        }
        catch (Exception ex)
        {
            Utils.WriteColored($"\n ⛔ Bir hata oluştu: {ex.Message}", ConsoleColor.Red);
        }
    }

    private static void ChooseLanguage()
    {
        var langManager = new LanguageManager();

        while (true)
        {
            Console.Clear();

            Console.CursorVisible = false;
            Utils.WriteColored(" 1. Türkçe");
            Utils.WriteColored(" 2. English");

            char choice = Console.ReadKey(true).KeyChar;

            switch (choice)
            {
                case '1':
                    langManager.SetLanguage(LanguageManager.Language.TR);
                    return;

                case '2':
                    langManager.SetLanguage(LanguageManager.Language.EN);
                    return;

                default:
                    Utils.WriteColored("\n ⚠️ Invalid Transaction! Please try again.", ConsoleColor.Yellow);
                    Thread.Sleep(800);
                    break;
            }
            Console.CursorVisible = true;
        }
    }

}
