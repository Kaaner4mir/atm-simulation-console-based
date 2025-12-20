# 🏦 ATM Simulation - Console Based

<div align="center">

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

![License](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)

**A comprehensive and multilingual console-based ATM (Automated Teller Machine) simulation with full banking operations**

[Features](#-features) • [Installation](#-installation) • [Usage](#-usage) • [Project Structure](#-project-structure) • [License](#-license)

</div>

---

## 📋 About

ATM Simulation is a feature-rich console-based banking application developed with .NET 8.0 and C#. It simulates a real-world ATM experience with comprehensive banking operations, multilingual support, secure authentication, and transaction logging capabilities.

### ✨ Features

- 🌍 **Multilingual Support** - 7 languages available (Turkish, English, German, French, Spanish, Italian, Russian)

- 🔐 **Secure Authentication** - PIN-based login system with attempt limiting and card blocking

- 💰 **Banking Operations**
  - **Withdraw Money** - Cash withdrawal from accounts
  - **Deposit Money** - Cash deposits to accounts
  - **Balance Inquiry** - View account balances and details
  - **Money Transfer** - Transfer between own accounts or to external accounts
  - **Transaction History** - View complete transaction logs

- 💾 **Account Management** - Multiple account support with account details (ID, name, branch, currency, balance, opening date)

- 📊 **Transaction Logging** - Complete transaction history with timestamps, types, and amounts

- 🎨 **Colorful Console Interface** - Visual appeal with different colors for each operation category

- ✅ **Error Handling** - Comprehensive error catching with user-friendly multilingual messages

- 🎬 **Smooth Animations** - Loading animations for better user experience

- 🔄 **Type-Safe Input** - Safe data input with generic type parameters and validation

- ⚡ **Minimum Transaction Limits** - Built-in validation for minimum transaction amounts (€10)

---

## 🚀 Installation

### Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or higher

### Steps

1. **Clone the repository**

   ```bash
   git clone https://github.com/Kaaner4mir/atm-simulation-console-based.git
   cd atm-simulation-console-based
   ```

2. **Build the project**

   ```bash
   dotnet build
   ```

3. **Run the application**

   ```bash
   dotnet run
   ```

---

## 🎮 Usage

When the application starts, you'll be prompted to select your preferred language. After language selection, you need to enter your 4-digit PIN (default: **1111**) to access the ATM system.

### Authentication

- **Default PIN**: 1111
- **Maximum Attempts**: 5
- After 5 failed attempts, the card will be blocked and the application will exit

### Main Menu Options

1. **Withdraw Money** 💸
   - Select account by ID
   - Enter withdrawal amount (minimum €10)
   - Validates sufficient balance
   - Updates account balance

2. **Deposit Money** 💵
   - Select account by ID
   - Enter deposit amount (minimum €10)
   - Updates account balance

3. **Balance Inquiry** 💰
   - View all accounts with details
   - Displays: Account ID, Name, Branch, Opening Date, Currency, Balance

4. **Money Transfer** 🔄
   - **Transfer with Account Number**: Transfer to external accounts
   - **Between My Accounts**: Transfer between your own accounts
   - Validates sufficient balance and prevents self-transfer

5. **Transaction History** 📜
   - View all logged transactions
   - Displays: Log ID, Time, Type, Transaction Amount

6. **Exit** 🚪
   - Confirmation prompt before exiting
   - Safely exits the application

### Supported Languages

1. **Türkçe** (Turkish)
2. **English**
3. **Deutsch** (German)
4. **Français** (French)
5. **Español** (Spanish)
6. **Italiano** (Italian)
7. **Русский** (Russian)

### Example Usage Flow

```
1. Select Language: Choose from 1-7
2. Enter PIN: 1111
3. Select Operation: Choose from 1-6
4. Follow on-screen prompts
5. View results and transaction confirmation
```

---

## 📁 Project Structure

```
AtmSimulation/
├── Database/
│   ├── Account.cs              # Account model (ID, Name, Branch, Currency, Balance, OpeningDate)
│   ├── Data.cs                 # Static data storage (accounts, foreign accounts, logs)
│   └── Log.cs                  # Transaction log model
│
├── Operations/
│   ├── Withdraw.cs             # Withdrawal operations
│   ├── Deposit.cs              # Deposit operations
│   ├── BalanceInquiry.cs       # Balance inquiry operations
│   ├── MoneyTransfer.cs        # Money transfer operations
│   ├── LogHistory.cs           # Transaction history display
│   ├── Logger.cs               # Transaction logging utility
│   ├── UserControl.cs          # PIN authentication and security
│   ├── LanguageManager.cs      # Multilingual support (7 languages)
│   ├── List.cs                 # Account listing utilities
│   ├── Animations.cs           # Console animations
│   └── Exit.cs                 # Exit operations
│
├── UI/
│   ├── Menu.cs                 # Menu management and display
│   └── Utils.cs                # Utility functions (colored output, input handling)
│
├── Initializer.cs              # Main entry point and application flow
├── AtmSimulation.csproj        # Project configuration
└── README.md                   # This file
```

---

## 🛠️ Technologies

- **.NET 8.0** - Framework
- **C#** - Programming language
- **Console Application** - Console-based user interface

---

## 🔧 Key Features Explained

### Multilingual Support

The application uses a centralized `LanguageManager` class that supports 7 languages. All user-facing text is dynamically loaded based on the selected language, providing a seamless experience for international users.

### Security

- PIN-based authentication with configurable attempts
- Card blocking after failed attempts
- Input validation for all operations

### Transaction Management

- All transactions are logged with:
  - Unique Log ID
  - Timestamp
  - Transaction Type (Withdraw, Deposit, Transfer)
  - Transaction Amount
- Account balances are updated in real-time
- Minimum transaction limits enforced (€10)

### Data Structure

- **Accounts**: Multiple bank accounts with complete details
- **Foreign Accounts**: External accounts for transfers
- **Logs**: Transaction history tracking

---

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork this repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📝 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## 👤 Author

**Kaaner4mir**

- GitHub: [@Kaaner4mir](https://github.com/Kaaner4mir)

---

<div align="center">

⭐ If you like this project, don't forget to give it a star!

Made with ❤️ using C# and .NET

</div>

