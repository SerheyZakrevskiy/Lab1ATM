using ClassLibraryBanking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibraryBanking
{
    public class AutomatedTellerMachine
    {
        public delegate void BankOperationsHandler(AutomatedTellerMachine sender,
       BankOperationsEventArgs e);
        public event BankOperationsHandler Notify;
        public int AtmID { get; protected set; }
        public double AtmBalance { get; set; }
        public string AtmAddress { get; protected set; }
        public AutomatedTellerMachine(int atmID, string atmAddress, double atmBalance)
        {
            AtmID = atmID;
            AtmAddress = atmAddress;
            AtmBalance = atmBalance;
        }
        public void Deposit(double sum, Account[] account, int user)
        {
            account[user].Balance += sum;
            AtmBalance += sum;
            Notify?.Invoke(this, new BankOperationsEventArgs($"На рахунок зараховано{ sum } UAH", sum));
        }
        public void Withdraw(double sum, Account[] account, int user)
        {
            if (AtmBalance >= sum)
            {
                if (account[user].Balance >= sum)
                {
                    {
                        account[user].Balance -= sum;
                        AtmBalance -= sum;
                        Notify?.Invoke(this, new BankOperationsEventArgs($"Знято {sum} UAH", sum));
                    }
                }
                else
                {
                    Notify?.Invoke(this, new BankOperationsEventArgs("Недостатньо коштів на рахунку", sum));
                }
            }
            else Notify?.Invoke(this, new BankOperationsEventArgs("Технічні проблеми. Будь ласка, спробуйте пізніше.", sum));
        }
        public bool Transfer(double sum, string cardNumber, Account[] account, int
       user)
        {
            bool check = false;
            if (account[user].Balance >= sum)
            {
                account[user].Balance -= sum;
                if (check == false)
                {
                    for (int j = 0; j < Account.usercount; j++)
                    {
                        if (account[j].CardNumber == cardNumber)
                        {
                            check = true;
                            account[j].Balance += sum;
                            Notify?.Invoke(this, new BankOperationsEventArgs($"{sum} UAH було перераховано на картку { cardNumber }", sum));
                        return true;
                        }
                    }
                    if (check == false) Notify?.Invoke(this, new BankOperationsEventArgs($"Картку {cardNumber} не знайдено", sum));
                }
            }
            else
            { Notify?.Invoke(this, new BankOperationsEventArgs("Недостатньо коштів на рахунку", sum));
 return false;
            }
            return false;
        }
    }
}
