using ClassLibraryBanking;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsBanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account[] account = {
 new Account("44411144413278795", 1111, "Serhiy", "Zakrevskiy",
"Serhey781@gmail.com", "+380639863345", 10000.00),
 new Account("1327879567899999",2222, "Vadim", "Truhan",
"TruhanVadim@gmail.com", "+380977008390", 210000.00),
    };
        AutomatedTellerMachine MyATM = new AutomatedTellerMachine(123456, "м.Житомир", 9999999.99);
        Bank MyBank = new Bank("MyBank", "м. Житомир", 123456);
        int user;
        bool flag;

        private void buttonAuthentfication_Click(object sender, EventArgs e)
        {
            string cardnum = textBoxcard_number.Text;
            int pin = CheckInt(textBoxpin_code.Text);
            flag = MyBank.Authentication(cardnum, pin, account, out user);
            if (flag == true)
            {
                textBoxcard_number.Text = "";
                textBoxpin_code.Text = "";
            }
            if (flag == false)
            {
                textBoxcard_number.Text = "";
                textBoxpin_code.Text = "";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MyBank.Notifications += ShowInfo;
            account[user].RegisterHandler(ShowInfo);
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                double sum = CheckDouble(textBoxAmount.Text);
                MyATM.Withdraw(sum, account, user);
                if (sum >= account[user].Balance)
                {
                    MessageBox.Show($"Недостатньо коштів.\nБаланс:{account[user].Balance}UAH");
                }
                else
                {
                    MessageBox.Show($"Знято{sum}UAH\nБаланс:{account[user].Balance}UAH");
                }
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                double sum = CheckDouble(textBoxAmount.Text);
                MyATM.Deposit(sum, account, user);
                MessageBox.Show($"Зараховано{sum}UAH\nБаланс:{account[user].Balance}UAH");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                double sum = CheckDouble(textBoxAmount.Text);
                string targetcard = textBoxTargcardnumber.Text;
                bool ok = MyATM.Transfer(sum, targetcard, account, user);

                if (ok == false)
                {
                    MessageBox.Show($"Недостатньо коштів.\nБаланс:{account[user].Balance}UAH");
                }
                else
                {
                    MessageBox.Show($"{sum}UAH було перераховано на картку: {targetcard}.\nБаланс:{account[user].Balance}UAH");
                }
            }
        }
        double CheckDouble(string text)
        {
            bool f;
            double x;
            f = double.TryParse(text, out x);
            if (f == false)
            {
                MessageBox.Show("Некоректне значення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return x;
        }
        int CheckInt(string text)
        {
            bool f;
            int x;

            f = int.TryParse(text, out x);
            if (f == false)
            {
                MessageBox.Show("Некоректне значення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return x;
        }
        void ShowInfo(string message)
        {
            MessageBox.Show($"{message}");
        }
        void DisplayMessage(AutomatedTellerMachine sender, BankOperationsEventArgs e)
        {
            MessageBox.Show($"Сума транзакції: {e.Sum} UAH");
            MessageBox.Show(e.Message);
        }
        private void buttonShow_nfo_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                account[user].PrintInfo();
            }
        }

        private void textBoxcard_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}