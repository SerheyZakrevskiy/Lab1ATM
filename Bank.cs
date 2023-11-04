using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate void BankHandler(string message);
    public class Bank
    {
        public delegate void BanksHandler(Bank sender, BanksEventArgs e);
        public event BankHandler Notifications;
        public string BankName { get; private set; }
        public string BankAddress { get; private set; }
        public int ListAtms { get; set; }
        public Bank(string bankName, string bankAddress, int listAtms)
        {
            BankName = bankName;
            BankAddress = bankAddress;
            ListAtms = listAtms;
        }
        public bool Authentication(string cardNumber, int cardPin, Account[] account,
       out int user)
        {
            user = -1;
            for (int i = 0; i < Account.usercount; i++)
            {
                if (account[i].CardNumber == cardNumber)
                {
                    if (account[i].CardPin == cardPin)
                    {
                        user = i;
                        Notifications?.Invoke("Aутентифікація успішна!");
                        return true;
                    }
                    else Notifications?.Invoke("Помилка введення даних! Повторіть
                    спробу!");
                return false;
                }
            }
            return false;
        }
    }
}
