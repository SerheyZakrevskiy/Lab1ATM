using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBanking;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Banking
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            System.Globalization.CultureInfo customCulture =
           (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.Title = "Лабораторна робота №1 Закревський Сергій";
            double CheckDouble()
            {
                bool f;
                double x;
                do
                {
                    f = double.TryParse(Console.ReadLine(), out x);
                    if (f == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid value");
                        Console.ResetColor();
                    }
                } while (!f);
                return x;
            }
            int CheckInt()
            {
                bool f;
                int x;
                do
                {
                    f = int.TryParse(Console.ReadLine(), out x);
                    if (f == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid value");
                        Console.ResetColor();
                    }
                } while (!f);
                return x;
            }
            Account[] account = {
 new Account("44411144413278795",1111, "Serhiy", "Zakrevskiy",
"Serhey781@gmail.com", "+380639863345", 10000.00),
 new Account("1327879567899999",2222, "Vadim", "Truhan",
"TruhanVadim@gmail.com", "+380977008390", 210000.00),
 };
            AutomatedTellerMachine MyATM = new AutomatedTellerMachine(123456, "м.Житомир", 9999999.99);           
            Bank MyBank = new Bank("MyBank", "м. Житомир", 123456);
            MyBank.Notifications += ShowInfo;
        auth:
            int user;
            bool flag = false;
            do
            {
                Console.WriteLine("Введіть номер картки: "); string cardnum = Console.ReadLine();
                Console.WriteLine("Введіть пін:код: "); int pin = CheckInt();
                flag = MyBank.Authentication(cardnum, pin, account, out user);
                Console.ReadKey();
            } while (!flag);

            Console.Clear();

            MyATM.Notify += DisplayMessage;
            account[user].RegisterHandler(ShowInfo);
            int printOption;
            do
            {
                Console.WriteLine("Виберіть опцію:");
                Console.WriteLine("1. Депозит");
                Console.WriteLine("2. Зняття коштів");
                Console.WriteLine("3. Подивитись інформацію");
                Console.WriteLine("4. Перекинути кошти");
                Console.WriteLine("5. Вийти");
                Console.WriteLine("6. Покинути\n");
                printOption = CheckInt();
                switch (printOption)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Введіть кількість коштів для депозиту: ");
                            double put = CheckDouble();
                            MyATM.Deposit(put, account, user);
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.Write("Введіть кількість коштів яку хочете зняти: ");
                            double take = CheckDouble();
                            MyATM.Withdraw(take, account, user);
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            account[user].PrintInfo();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.Write("Enter an amount: "); double sum =
                            CheckDouble();
                            Console.Write("Enter target card number: ");
                            MyATM.Transfer(sum, Console.ReadLine(), account, user);
                        }
                        break;
                    case 5: Console.Clear(); goto auth;
                    case 6:Environment.Exit(0); 
                        break;
                }
            } while (printOption != 0);
            void DisplayMessage(AutomatedTellerMachine sender, BankOperationsEventArgs e)
            {
                Console.WriteLine($"Sum: {e.Sum} UAH");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            void ShowInfo(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}