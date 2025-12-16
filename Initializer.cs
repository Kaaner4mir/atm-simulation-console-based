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
            Utils.WriteColored($"\n ⛔ An error has occurred: {ex.Message}", ConsoleColor.Red);
        }
    }

    private static void ChooseLanguage()
    {
        while (true)
        {
            Console.Clear();

            var langManager = new LanguageManager();

            Utils.WriteColored("[T] Türkçe", ConsoleColor.Red);
            Utils.WriteColored("[E] English", ConsoleColor.Cyan);

            char choice = char.ToUpper(Console.ReadKey(true).KeyChar);

            if (choice == 'T')
            {
                langManager.SetLanguage(LanguageManager.Language.TR);
                break;
            }
            else if (choice == 'E')
            {
                langManager.SetLanguage(LanguageManager.Language.EN);
                break;
            }
            else
                continue;
        }
    }
}