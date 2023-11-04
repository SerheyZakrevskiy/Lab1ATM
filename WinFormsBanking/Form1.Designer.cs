namespace WinFormsBanking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxcard_number = new TextBox();
            textBoxpin_code = new TextBox();
            buttonAuthentfication = new Button();
            buttonDeposit = new Button();
            buttonWithdraw = new Button();
            buttonShow_info = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxAmount = new TextBox();
            textBoxTargcardnumber = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxcard_number
            // 
            textBoxcard_number.BackColor = Color.FromArgb(224, 224, 224);
            textBoxcard_number.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxcard_number.Location = new Point(1165, 373);
            textBoxcard_number.Margin = new Padding(5);
            textBoxcard_number.Multiline = true;
            textBoxcard_number.Name = "textBoxcard_number";
            textBoxcard_number.Size = new Size(433, 59);
            textBoxcard_number.TabIndex = 0;
            textBoxcard_number.TextChanged += textBoxcard_number_TextChanged;
            // 
            // textBoxpin_code
            // 
            textBoxpin_code.BackColor = Color.FromArgb(224, 224, 224);
            textBoxpin_code.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxpin_code.Location = new Point(1336, 529);
            textBoxpin_code.Margin = new Padding(5);
            textBoxpin_code.Multiline = true;
            textBoxpin_code.Name = "textBoxpin_code";
            textBoxpin_code.PasswordChar = '*';
            textBoxpin_code.Size = new Size(251, 66);
            textBoxpin_code.TabIndex = 1;
            // 
            // buttonAuthentfication
            // 
            buttonAuthentfication.BackColor = Color.FromArgb(255, 224, 192);
            buttonAuthentfication.Cursor = Cursors.Hand;
            buttonAuthentfication.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAuthentfication.Location = new Point(33, 22);
            buttonAuthentfication.Margin = new Padding(5);
            buttonAuthentfication.Name = "buttonAuthentfication";
            buttonAuthentfication.Size = new Size(252, 62);
            buttonAuthentfication.TabIndex = 2;
            buttonAuthentfication.Text = "Авторизація";
            buttonAuthentfication.UseVisualStyleBackColor = false;
            buttonAuthentfication.Click += buttonAuthentfication_Click;
            // 
            // buttonDeposit
            // 
            buttonDeposit.BackColor = Color.FromArgb(255, 224, 192);
            buttonDeposit.Cursor = Cursors.Hand;
            buttonDeposit.Location = new Point(33, 116);
            buttonDeposit.Margin = new Padding(5);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(252, 66);
            buttonDeposit.TabIndex = 3;
            buttonDeposit.Text = "Депозит";
            buttonDeposit.UseVisualStyleBackColor = false;
            buttonDeposit.Click += buttonDeposit_Click;
            // 
            // buttonWithdraw
            // 
            buttonWithdraw.BackColor = Color.FromArgb(255, 224, 192);
            buttonWithdraw.Cursor = Cursors.Hand;
            buttonWithdraw.Location = new Point(33, 205);
            buttonWithdraw.Margin = new Padding(5);
            buttonWithdraw.Name = "buttonWithdraw";
            buttonWithdraw.Size = new Size(252, 71);
            buttonWithdraw.TabIndex = 4;
            buttonWithdraw.Text = "Знять кошти";
            buttonWithdraw.UseVisualStyleBackColor = false;
            buttonWithdraw.Click += buttonWithdraw_Click;
            // 
            // buttonShow_info
            // 
            buttonShow_info.BackColor = Color.FromArgb(255, 224, 192);
            buttonShow_info.Cursor = Cursors.Hand;
            buttonShow_info.Location = new Point(33, 293);
            buttonShow_info.Margin = new Padding(5);
            buttonShow_info.Name = "buttonShow_info";
            buttonShow_info.Size = new Size(264, 87);
            buttonShow_info.TabIndex = 5;
            buttonShow_info.Text = "Подивитись інформацію";
            buttonShow_info.UseVisualStyleBackColor = false;
            buttonShow_info.Click += buttonShow_nfo_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1221, 294);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 74);
            label1.TabIndex = 7;
            label1.Text = "Номер карти";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1333, 450);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(254, 74);
            label2.TabIndex = 8;
            label2.Text = "Пін код";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxAmount
            // 
            textBoxAmount.BackColor = Color.FromArgb(224, 224, 224);
            textBoxAmount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAmount.Location = new Point(1258, 91);
            textBoxAmount.Margin = new Padding(5);
            textBoxAmount.Multiline = true;
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(340, 53);
            textBoxAmount.TabIndex = 9;
            textBoxAmount.TextChanged += textBoxAmount_TextChanged;
            // 
            // textBoxTargcardnumber
            // 
            textBoxTargcardnumber.BackColor = Color.FromArgb(224, 224, 224);
            textBoxTargcardnumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTargcardnumber.Location = new Point(1258, 222);
            textBoxTargcardnumber.Margin = new Padding(5);
            textBoxTargcardnumber.Multiline = true;
            textBoxTargcardnumber.Name = "textBoxTargcardnumber";
            textBoxTargcardnumber.Size = new Size(339, 65);
            textBoxTargcardnumber.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(33, 399);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(264, 83);
            button1.TabIndex = 11;
            button1.Text = "Перекинути кошти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 224, 192);
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1258, 36);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(340, 50);
            label3.TabIndex = 12;
            label3.Text = "Поповнення карти";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 224, 192);
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1141, 167);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(457, 50);
            label4.TabIndex = 13;
            label4.Text = "Номер карти отримувача";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1637, 905);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBoxTargcardnumber);
            Controls.Add(textBoxAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonShow_info);
            Controls.Add(buttonWithdraw);
            Controls.Add(buttonDeposit);
            Controls.Add(buttonAuthentfication);
            Controls.Add(textBoxpin_code);
            Controls.Add(textBoxcard_number);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1313, 753);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATM";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxcard_number;
        private TextBox textBoxpin_code;
        private Button buttonAuthentfication;
        private Button buttonDeposit;
        private Button buttonWithdraw;
        private Button buttonShow_info;
        private Label label1;
        private Label label2;
        private TextBox textBoxAmount;
        private TextBox textBoxTargcardnumber;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}