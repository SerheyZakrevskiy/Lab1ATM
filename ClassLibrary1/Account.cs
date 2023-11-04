using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibraryBanking
{
    public delegate void AccountHandler(string message);
    public class Account
    {
        public delegate void BankOperationsHandler(Account sender,
       BankOperationsEventArgs e);
        public static int usercount = 0;
        public string CardNumber { get; private set; }
        public int CardPin { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public double Balance { get; set; }
        AccountHandler info;
        public Account(string cardNumber, int cardPin, string firstName, string
       lastName, string email, string phone, double balance)
        {
            CardNumber = cardNumber;
            CardPin = cardPin;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Balance = balance;
            usercount++;
        }
        public void RegisterHandler(AccountHandler del)
        {
            info = del;
        }
        public void PrintInfo()
        {
            info?.Invoke($"Ім'я: {FirstName}\nПрізвище: {LastName}\nНомер картки:{ CardNumber}\nEmail: { Email}\nТелефон: { Phone}\nБаланс: { Balance}");
        }
        public void PrintBalance()
        {
            info?.Invoke($"Баланс: {Balance}");
        }
    }
}