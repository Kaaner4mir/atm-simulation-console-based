public class LanguageManager
{
    public enum Language
    {
        TR,
        EN,
        DE,
        FR,
        ES,
        IT,
        RU
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
        { "Id", " 🔑 Hesap ID" },
        { "Name", " 🏷️ Hesap Adı" },
        { "Branch", " 🏦 Şube" },
        { "OpeningDate", " 📆 Açılış Tarihi" },
        { "Currency", " 💱 Para Birimi" },
        { "Balance", " 💰 Bakiye" },

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


        // LogHistory
        {"LogId"," 🔑 Kayıt ID"},
        {"LogTime"," ⌛ Kayıt Zamanı"},
        {"Type"," 🔠 Tür"},
        {"LogTransactionAmount"," 💰 İşlem Tutarı"},


        //UserControl
        {"CardPassword","\n 🪪 Lütfen bankaya kayıtlı 4 haneli kart şifrenizi giriniz: "},
        {"TruePassword","\n ✅ Şifre doğru! Hoş geldiniz"},
        {"WrongPassword","\n ❌ Hatalı şifre! Kalan deneme hakkınız: {0}"},
        {"Blocked","\n ⚠️ Çok fazla hatalı şifre girişi nedeniyle kartınız geçici olarak bloke edilmiştir. Lütfen en kısa sürede müşteri hizmetleri ile iletişime geçiniz."},

        // Exceptions and Errors
        { "AccountNotFound", "\n ❓ Hesap bulunamadı!" },
        { "Catch", "\n ⛔ Bir hata oluştu: {0}" },
        { "InvalidOperation", "\n ❓ Yapmak istediğiniz işlem geçersizdir!" },
        { "InvalidTransaction", "\n ❓ Geçersiz işlem!" },

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
        { "Id", " 🔑 Account ID" },
        { "Name", " 🏷️ Account Name" },
        { "Branch", " 🏦 Branch" },
        { "OpeningDate", " 📆 Opening Date" },
        { "Currency", " 💱 Currency" },
        { "Balance", " 💰 Balance" },

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


        // LogHistory
        {"LogId"," 🔑 Log ID"},
        {"LogTime"," ⌛ Log Time"},
        {"Type"," 🔠 Type"},
        {"LogTransactionAmount"," 💰 Transaction Amount"},


        //Exit
        {"ExitOperation"," ➡️ Are you sure you want to exit (Y-N): "},


        //UserControl
        {"CardPassword","\n 🪪 Please enter your 4-digit card PIN registered with the bank: "},
        {"TruePassword","\n ✅ Password is correct! Welcome"},
        {"WrongPassword","\n ❌ Incorrect password You have {0} attempts remaining"},
        {"Blocked","\n ⚠️ Your card has been temporarily blocked due to too many incorrect password entries. Please contact customer service as soon as possible."},

        // Exceptions and Errors
        { "AccountNotFound", "\n ❓ Account not found!" },
        { "Catch", "\n ⛔ An error has occurred: {0}" },
        { "InvalidOperation", "\n ❓ The operation you want to perform is invalid!" },
        { "InvalidTransaction", "\n ❓ Invalid transaction!" },

        // General
        { "SelectLanguage", "Select Language" },
        { "EnterChoice", "Enter your choice" },
        { "GetInputMain", "\n 👉 Please enter the operation you wish to perform numerically: " }
    };

    private static readonly Dictionary<string, string> DE = new()
    {
        // Main Menu
        { "MainMenu", "📝 Hauptmenü" },
        { "Withdraw", "Geld abheben" },
        { "Deposit", "Geld einzahlen" },
        { "BalanceInquiry", "Kontostandsabfrage" },
        { "MoneyTransfer", "Geldüberweisung" },
        { "Payments", "Zahlungen" },
        { "TransactionHistory", "Transaktionsverlauf" },
        { "Exit", "Beenden" },

        // List
        { "Id", " 🔑 Kontonummer" },
        { "Name", " 🏷️ Kontoname" },
        { "Branch", " 🏦 Filiale" },
        { "OpeningDate", " 📆 Eröffnungsdatum" },
        { "Currency", " 💱 Währung" },
        { "Balance", " 💰 Kontostand" },

        // Withdraw Menu
        { "WishWithdraw", "\n 👉 Bitte geben Sie die Kontonummer ein, von der Sie Geld abheben möchten: " },
        { "AmountWithdraw", "\n ➡️ Bitte geben Sie den Betrag ein, den Sie vom Konto abheben möchten: " },
        { "MinWithdrawAmount", "\n ❌ Der Mindestbetrag, den Sie abheben können, beträgt €10." },
        { "InsufficientBalance", "\n ❌ Unzureichender Kontostand!" },
        { "ResultWithdraw", " ✅ {0}{1} wurde erfolgreich von Ihrem Konto abgehoben. Neuer Kontostand: {0}{2}" },

        // Deposit Menu
        { "WishDeposit", "\n 👉 Bitte geben Sie die Kontonummer ein, auf die Sie Geld einzahlen möchten: " },
        { "AmountDeposit", "\n ➡️ Bitte geben Sie den Betrag ein, den Sie auf das Konto einzahlen möchten: " },
        { "MinDepositAmount", "\n ❌ Der Mindestbetrag, den Sie einzahlen können, beträgt €10." },
        { "ResultDeposit", " ✅ {0}{1} wurde erfolgreich auf Ihr Konto eingezahlt. Neuer Kontostand: {0}{2}" },

        // Transfer Menu
        { "TransferMenu", "📲 Überweisungsmenü" },
        { "TransferWithAccountNumber", "Überweisung mit Kontonummer" },
        { "BetweenMyAccounts", "Zwischen meinen Konten" },
        { "TransferId", "\n ➡️ Bitte geben Sie die Kontonummer ein, an die Sie Geld überweisen möchten: " },
        { "SenderId", "\n ➡️ Bitte geben Sie die Kontonummer des Absenderkontos ein: " },
        { "TransferAmount", "\n ➡️ Geben Sie den Betrag ein, den Sie überweisen möchten: " },
        { "MinTransferAmount", "\n ❌ Der Mindestbetrag, den Sie überweisen können, beträgt €10." },
        { "ResultTransfer", " ✅ {0}{1} wurde erfolgreich überwiesen. Neuer Kontostand: {0}{2}" },
        { "RecieverId", "\n ➡️ Bitte geben Sie die Kontonummer des Empfängerkontos ein: " },

        // LogHistory
        {"LogId"," 🔑 Protokoll-ID"},
        {"LogTime"," ⌛ Protokollzeit"},
        {"Type"," 🔠 Typ"},
        {"LogTransactionAmount"," 💰 Transaktionsbetrag"},

        //Exit
        {"ExitOperation"," ➡️ Möchten Sie wirklich beenden (J-N): "},

        //UserControl
        {"CardPassword","\n 🪪 Bitte geben Sie Ihre 4-stellige Karten-PIN ein, die bei der Bank registriert ist: "},
        {"TruePassword","\n ✅ Passwort ist korrekt! Willkommen"},
        {"WrongPassword","\n ❌ Falsches Passwort! Sie haben noch {0} Versuche"},
        {"Blocked","\n ⚠️ Ihre Karte wurde aufgrund zu vieler falscher Passworteingaben vorübergehend gesperrt. Bitte kontaktieren Sie so bald wie möglich den Kundendienst."},

        // Exceptions and Errors
        { "AccountNotFound", "\n ❓ Konto nicht gefunden!" },
        { "Catch", "\n ⛔ Ein Fehler ist aufgetreten: {0}" },
        { "InvalidOperation", "\n ❓ Die gewünschte Operation ist ungültig!" },
        { "InvalidTransaction", "\n ❓ Ungültige Transaktion!" },

        // General
        { "SelectLanguage", "Sprache auswählen" },
        { "EnterChoice", "Geben Sie Ihre Wahl ein" },
        { "GetInputMain", "\n 👉 Bitte geben Sie die gewünschte Operation numerisch ein: " }
    };

    private static readonly Dictionary<string, string> FR = new()
    {
        // Main Menu
        { "MainMenu", "📝 Menu principal" },
        { "Withdraw", "Retirer de l'argent" },
        { "Deposit", "Déposer de l'argent" },
        { "BalanceInquiry", "Consultation du solde" },
        { "MoneyTransfer", "Virement bancaire" },
        { "Payments", "Paiements" },
        { "TransactionHistory", "Historique des transactions" },
        { "Exit", "Quitter" },

        // List
        { "Id", " 🔑 Numéro de compte" },
        { "Name", " 🏷️ Nom du compte" },
        { "Branch", " 🏦 Agence" },
        { "OpeningDate", " 📆 Date d'ouverture" },
        { "Currency", " 💱 Devise" },
        { "Balance", " 💰 Solde" },

        // Withdraw Menu
        { "WishWithdraw", "\n 👉 Veuillez saisir le numéro de compte dont vous souhaitez retirer de l'argent: " },
        { "AmountWithdraw", "\n ➡️ Veuillez saisir le montant que vous souhaitez retirer du compte: " },
        { "MinWithdrawAmount", "\n ❌ Le montant minimum que vous pouvez retirer est de €10." },
        { "InsufficientBalance", "\n ❌ Solde insuffisant!" },
        { "ResultWithdraw", " ✅ {0}{1} a été retiré avec succès de votre compte. Nouveau solde: {0}{2}" },

        // Deposit Menu
        { "WishDeposit", "\n 👉 Veuillez saisir le numéro de compte sur lequel vous souhaitez déposer de l'argent: " },
        { "AmountDeposit", "\n ➡️ Veuillez saisir le montant que vous souhaitez déposer sur le compte: " },
        { "MinDepositAmount", "\n ❌ Le montant minimum que vous pouvez déposer est de €10." },
        { "ResultDeposit", " ✅ {0}{1} a été déposé avec succès sur votre compte. Nouveau solde: {0}{2}" },

        // Transfer Menu
        { "TransferMenu", "📲 Menu de virement" },
        { "TransferWithAccountNumber", "Virement avec numéro de compte" },
        { "BetweenMyAccounts", "Entre mes comptes" },
        { "TransferId", "\n ➡️ Veuillez saisir le numéro de compte vers lequel vous souhaitez transférer de l'argent: " },
        { "SenderId", "\n ➡️ Veuillez saisir le numéro de compte de l'expéditeur: " },
        { "TransferAmount", "\n ➡️ Saisissez le montant que vous souhaitez envoyer: " },
        { "MinTransferAmount", "\n ❌ Le montant minimum que vous pouvez envoyer est de €10." },
        { "ResultTransfer", " ✅ {0}{1} a été transféré avec succès. Nouveau solde: {0}{2}" },
        { "RecieverId", "\n ➡️ Veuillez saisir le numéro de compte du destinataire: " },

        // LogHistory
        {"LogId"," 🔑 ID du journal"},
        {"LogTime"," ⌛ Heure du journal"},
        {"Type"," 🔠 Type"},
        {"LogTransactionAmount"," 💰 Montant transaction"},

        //Exit
        {"ExitOperation"," ➡️ Êtes-vous sûr de vouloir quitter (O-N): "},

        //UserControl
        {"CardPassword","\n 🪪 Veuillez saisir votre code PIN à 4 chiffres enregistré auprès de la banque: "},
        {"TruePassword","\n ✅ Le mot de passe est correct! Bienvenue"},
        {"WrongPassword","\n ❌ Mot de passe incorrect! Il vous reste {0} tentatives"},
        {"Blocked","\n ⚠️ Votre carte a été temporairement bloquée en raison de trop nombreuses saisies de mot de passe incorrect. Veuillez contacter le service client dès que possible."},

        // Exceptions and Errors
        { "AccountNotFound", "\n ❓ Compte introuvable!" },
        { "Catch", "\n ⛔ Une erreur s'est produite: {0}" },
        { "InvalidOperation", "\n ❓ L'opération que vous souhaitez effectuer est invalide!" },
        { "InvalidTransaction", "\n ❓ Transaction invalide!" },

        // General
        { "SelectLanguage", "Sélectionner la langue" },
        { "EnterChoice", "Entrez votre choix" },
        { "GetInputMain", "\n 👉 Veuillez saisir l'opération que vous souhaitez effectuer numériquement: " }
    };

    private static readonly Dictionary<string, string> ES = new()
    {
        // Main Menu
        { "MainMenu", "📝 Menú principal" },
        { "Withdraw", "Retirar dinero" },
        { "Deposit", "Ingresar dinero" },
        { "BalanceInquiry", "Consulta de saldo" },
        { "MoneyTransfer", "Transferencia de dinero" },
        { "Payments", "Pagos" },
        { "TransactionHistory", "Historial de transacciones" },
        { "Exit", "Salir" },

        // List
        { "Id", " 🔑 ID de cuenta" },
        { "Name", " 🏷️ Nombre cuenta" },
        { "Branch", " 🏦 Sucursal" },
        { "OpeningDate", " 📆 Fecha apertura" },
        { "Currency", " 💱 Moneda" },
        { "Balance", " 💰 Saldo" },

        // Withdraw Menu
        { "WishWithdraw", "\n 👉 Por favor ingrese el ID de la cuenta de la que desea retirar dinero: " },
        { "AmountWithdraw", "\n ➡️ Por favor ingrese la cantidad que desea retirar de la cuenta: " },
        { "MinWithdrawAmount", "\n ❌ La cantidad mínima que puede retirar es €10." },
        { "InsufficientBalance", "\n ❌ ¡Saldo insuficiente!" },
        { "ResultWithdraw", " ✅ {0}{1} ha sido retirado exitosamente de su cuenta. Nuevo saldo: {0}{2}" },

        // Deposit Menu
        { "WishDeposit", "\n 👉 Por favor ingrese el ID de la cuenta en la que desea depositar dinero: " },
        { "AmountDeposit", "\n ➡️ Por favor ingrese la cantidad que desea depositar en la cuenta: " },
        { "MinDepositAmount", "\n ❌ La cantidad mínima que puede depositar es €10." },
        { "ResultDeposit", " ✅ {0}{1} ha sido depositado exitosamente en su cuenta. Nuevo saldo: {0}{2}" },

        // Transfer Menu
        { "TransferMenu", "📲 Menú de transferencia" },
        { "TransferWithAccountNumber", "Transferencia con número de cuenta" },
        { "BetweenMyAccounts", "Entre mis cuentas" },
        { "TransferId", "\n ➡️ Por favor ingrese el número de cuenta al que desea transferir dinero: " },
        { "SenderId", "\n ➡️ Por favor ingrese el número de cuenta asociado con la cuenta del remitente: " },
        { "TransferAmount", "\n ➡️ Ingrese la cantidad que desea enviar: " },
        { "MinTransferAmount", "\n ❌ La cantidad mínima que puede enviar es €10." },
        { "ResultTransfer", " ✅ {0}{1} ha sido transferido exitosamente. Nuevo saldo: {0}{2}" },
        { "RecieverId", "\n ➡️ Por favor ingrese el número de cuenta asociado con la cuenta del destinatario: " },

        // LogHistory
        {"LogId"," 🔑 ID de registro"},
        {"LogTime"," ⌛ Hora registro"},
        {"Type"," 🔠 Tipo"},
        {"LogTransactionAmount"," 💰 Monto transacción"},

        //Exit
        {"ExitOperation"," ➡️ ¿Está seguro de que desea salir (S-N): "},

        //UserControl
        {"CardPassword","\n 🪪 Por favor ingrese su PIN de tarjeta de 4 dígitos registrado en el banco: "},
        {"TruePassword","\n ✅ ¡La contraseña es correcta! Bienvenido"},
        {"WrongPassword","\n ❌ Contraseña incorrecta! Le quedan {0} intentos"},
        {"Blocked","\n ⚠️ Su tarjeta ha sido bloqueada temporalmente debido a demasiados intentos de contraseña incorrectos. Por favor contacte al servicio al cliente lo antes posible."},

        // Exceptions and Errors
        { "AccountNotFound", "\n ❓ ¡Cuenta no encontrada!" },
        { "Catch", "\n ⛔ Ha ocurrido un error: {0}" },
        { "InvalidOperation", "\n ❓ ¡La operación que desea realizar es inválida!" },
        { "InvalidTransaction", "\n ❓ ¡Transacción inválida!" },

        // General
        { "SelectLanguage", "Seleccionar idioma" },
        { "EnterChoice", "Ingrese su elección" },
        { "GetInputMain", "\n 👉 Por favor ingrese la operación que desea realizar numéricamente: " }
    };

    private static readonly Dictionary<string, string> IT = new()
    {
        // Main Menu
        { "MainMenu", "📝 Menu principale" },
        { "Withdraw", "Preleva denaro" },
        { "Deposit", "Deposita denaro" },
        { "BalanceInquiry", "Consulta saldo" },
        { "MoneyTransfer", "Bonifico bancario" },
        { "Payments", "Pagamenti" },
        { "TransactionHistory", "Cronologia transazioni" },
        { "Exit", "Esci" },

        // List
        { "Id", " 🔑 ID conto" },
        { "Name", " 🏷️ Nome conto" },
        { "Branch", " 🏦 Filiale" },
        { "OpeningDate", " 📆 Data apertura" },
        { "Currency", " 💱 Valuta" },
        { "Balance", " 💰 Saldo" },

        // Withdraw Menu
        { "WishWithdraw", "\n 👉 Si prega di inserire l'ID del conto da cui si desidera prelevare denaro: " },
        { "AmountWithdraw", "\n ➡️ Si prega di inserire l'importo che si desidera prelevare dal conto: " },
        { "MinWithdrawAmount", "\n ❌ L'importo minimo che è possibile prelevare è €10." },
        { "InsufficientBalance", "\n ❌ Saldo insufficiente!" },
        { "ResultWithdraw", " ✅ {0}{1} è stato prelevato con successo dal tuo conto. Nuovo saldo: {0}{2}" },

        // Deposit Menu
        { "WishDeposit", "\n 👉 Si prega di inserire l'ID del conto su cui si desidera depositare denaro: " },
        { "AmountDeposit", "\n ➡️ Si prega di inserire l'importo che si desidera depositare sul conto: " },
        { "MinDepositAmount", "\n ❌ L'importo minimo che è possibile depositare è €10." },
        { "ResultDeposit", " ✅ {0}{1} è stato depositato con successo sul tuo conto. Nuovo saldo: {0}{2}" },

        // Transfer Menu
        { "TransferMenu", "📲 Menu bonifico" },
        { "TransferWithAccountNumber", "Bonifico con numero di conto" },
        { "BetweenMyAccounts", "Tra i miei conti" },
        { "TransferId", "\n ➡️ Si prega di inserire il numero di conto a cui si desidera trasferire denaro: " },
        { "SenderId", "\n ➡️ Si prega di inserire il numero di conto associato al conto del mittente: " },
        { "TransferAmount", "\n ➡️ Inserisci l'importo che desideri inviare: " },
        { "MinTransferAmount", "\n ❌ L'importo minimo che è possibile inviare è €10." },
        { "ResultTransfer", " ✅ {0}{1} è stato trasferito con successo. Nuovo saldo: {0}{2}" },
        { "RecieverId", "\n ➡️ Si prega di inserire il numero di conto associato al conto del destinatario: " },

        // LogHistory
        {"LogId"," 🔑 ID registro"},
        {"LogTime"," ⌛ Ora registro"},
        {"Type"," 🔠 Tipo"},
        {"LogTransactionAmount"," 💰 Importo transazione"},

        //Exit
        {"ExitOperation"," ➡️ Sei sicuro di voler uscire (S-N): "},

        //UserControl
        {"CardPassword","\n 🪪 Si prega di inserire il PIN della carta a 4 cifre registrato presso la banca: "},
        {"TruePassword","\n ✅ La password è corretta! Benvenuto"},
        {"WrongPassword","\n ❌ Password errata! Hai ancora {0} tentativi"},
        {"Blocked","\n ⚠️ La tua carta è stata temporaneamente bloccata a causa di troppi tentativi di password errati. Si prega di contattare il servizio clienti il prima possibile."},

        // Exceptions and Errors
        { "AccountNotFound", "\n ❓ Conto non trovato!" },
        { "Catch", "\n ⛔ Si è verificato un errore: {0}" },
        { "InvalidOperation", "\n ❓ L'operazione che si desidera eseguire non è valida!" },
        { "InvalidTransaction", "\n ❓ Transazione non valida!" },

        // General
        { "SelectLanguage", "Seleziona lingua" },
        { "EnterChoice", "Inserisci la tua scelta" },
        { "GetInputMain", "\n 👉 Si prega di inserire l'operazione che si desidera eseguire numericamente: " }
    };

    private static readonly Dictionary<string, string> RU = new()
    {
        // Main Menu
        { "MainMenu", "📝 Главное меню" },
        { "Withdraw", "Снять деньги" },
        { "Deposit", "Внести деньги" },
        { "BalanceInquiry", "Запрос баланса" },
        { "MoneyTransfer", "Перевод денег" },
        { "Payments", "Платежи" },
        { "TransactionHistory", "История транзакций" },
        { "Exit", "Выход" },

        // List
        { "Id", " 🔑 ID счета" },
        { "Name", " 🏷️ Название счета" },
        { "Branch", " 🏦 Филиал" },
        { "OpeningDate", " 📆 Дата открытия" },
        { "Currency", " 💱 Валюта" },
        { "Balance", " 💰 Баланс" },

        // Withdraw Menu
        { "WishWithdraw", "\n 👉 Пожалуйста, введите ID счета, с которого вы хотите снять деньги: " },
        { "AmountWithdraw", "\n ➡️ Пожалуйста, введите сумму, которую вы хотите снять со счета: " },
        { "MinWithdrawAmount", "\n ❌ Минимальная сумма для снятия составляет €10." },
        { "InsufficientBalance", "\n ❌ Недостаточно средств!" },
        { "ResultWithdraw", " ✅ {0}{1} успешно снято с вашего счета. Новый баланс: {0}{2}" },

        // Deposit Menu
        { "WishDeposit", "\n 👉 Пожалуйста, введите ID счета, на который вы хотите внести деньги: " },
        { "AmountDeposit", "\n ➡️ Пожалуйста, введите сумму, которую вы хотите внести на счет: " },
        { "MinDepositAmount", "\n ❌ Минимальная сумма для внесения составляет €10." },
        { "ResultDeposit", " ✅ {0}{1} успешно внесено на ваш счет. Новый баланс: {0}{2}" },

        // Transfer Menu
        { "TransferMenu", "📲 Меню перевода" },
        { "TransferWithAccountNumber", "Перевод по номеру счета" },
        { "BetweenMyAccounts", "Между моими счетами" },
        { "TransferId", "\n ➡️ Пожалуйста, введите номер счета, на который вы хотите перевести деньги: " },
        { "SenderId", "\n ➡️ Пожалуйста, введите номер счета отправителя: " },
        { "TransferAmount", "\n ➡️ Введите сумму, которую вы хотите отправить: " },
        { "MinTransferAmount", "\n ❌ Минимальная сумма для перевода составляет €10." },
        { "ResultTransfer", " ✅ {0}{1} успешно переведено. Новый баланс: {0}{2}" },
        { "RecieverId", "\n ➡️ Пожалуйста, введите номер счета получателя: " },

        // LogHistory
        {"LogId"," 🔑 ID записи"},
        {"LogTime"," ⌛ Время записи"},
        {"Type"," 🔠 Тип"},
        {"LogTransactionAmount"," 💰 Сумма транзакции"},

        //Exit
        {"ExitOperation"," ➡️ Вы уверены, что хотите выйти (Д-Н): "},

        //UserControl
        {"CardPassword","\n 🪪 Пожалуйста, введите 4-значный PIN-код карты, зарегистрированный в банке: "},
        {"TruePassword","\n ✅ Пароль правильный! Добро пожаловать"},
        {"WrongPassword","\n ❌ Неверный пароль! У вас осталось {0} попыток"},
        {"Blocked","\n ⚠️ Ваша карта была временно заблокирована из-за слишком большого количества неверных вводов пароля. Пожалуйста, как можно скорее свяжитесь со службой поддержки клиентов."},

        // Exceptions and Errors
        { "AccountNotFound", "\n ❓ Счет не найден!" },
        { "Catch", "\n ⛔ Произошла ошибка: {0}" },
        { "InvalidOperation", "\n ❓ Операция, которую вы хотите выполнить, недействительна!" },
        { "InvalidTransaction", "\n ❓ Недействительная транзакция!" },

        // General
        { "SelectLanguage", "Выберите язык" },
        { "EnterChoice", "Введите свой выбор" },
        { "GetInputMain", "\n 👉 Пожалуйста, введите операцию, которую вы хотите выполнить, числом: " }
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
            Language.DE => DE[key],
            Language.FR => FR[key],
            Language.ES => ES[key],
            Language.IT => IT[key],
            Language.RU => RU[key],
            _ => key
        };
    }
}
