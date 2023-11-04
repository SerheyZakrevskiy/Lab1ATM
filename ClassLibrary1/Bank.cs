using ClassLibraryBanking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibraryBanking
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
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("vt222_zso@student.ztu.edu.ua", "008536"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            user = -1;
            for (int i = 0; i < Account.usercount; i++)
            {
                if (account[i].CardNumber == cardNumber)
                {
                    if (account[i].CardPin == cardPin)
                    {
                        user = i;
                        Notifications?.Invoke("Aутентифікація успішна!");
                        //smtpClient.Send("vt222_zso@student.ztu.edu.ua", "serhey781@gmail.com", "Аунтефікація", "Успішно");
                        return true;
                    }
                    else
                    {
                        Notifications?.Invoke("Помилка введення даних! Повторіть спробу!");
                        //smtpClient.Send("vt222_zso@student.ztu.edu.ua", "serhey781@gmail.com", "Аунтефікація", "Не успішна, якщо це ви підтвердіть особу");
                        return false;
                    }
                }
            }
            return false;
        }
    }
}