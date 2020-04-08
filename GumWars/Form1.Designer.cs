namespace GumWars
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._grpMarket = new System.Windows.Forms.GroupBox();
            this._grdMarket = new System.Windows.Forms.DataGridView();
            this._grpYou = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this._txtDepositAmount = new System.Windows.Forms.TextBox();
            this._llLoanShark = new System.Windows.Forms.LinkLabel();
            this._lblLoan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._llBankWithdraw = new System.Windows.Forms.LinkLabel();
            this._llBankDeposit = new System.Windows.Forms.LinkLabel();
            this._lblBank = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._llAddCapacity = new System.Windows.Forms.LinkLabel();
            this._lblRemainingCapacity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._lblMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cmbSelectedCity = new System.Windows.Forms.ComboBox();
            this._grdInventory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this._lblDaysLeft = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._llHighScores = new System.Windows.Forms.LinkLabel();
            this._llNewGame = new System.Windows.Forms.LinkLabel();
            this._lblGameStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this._grpMarket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grdMarket)).BeginInit();
            this._grpYou.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grdInventory)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _grpMarket
            // 
            this._grpMarket.Controls.Add(this._grdMarket);
            this._grpMarket.Location = new System.Drawing.Point(396, 97);
            this._grpMarket.Name = "_grpMarket";
            this._grpMarket.Size = new System.Drawing.Size(388, 337);
            this._grpMarket.TabIndex = 0;
            this._grpMarket.TabStop = false;
            this._grpMarket.Text = "Current Market";
            // 
            // _grdMarket
            // 
            this._grdMarket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grdMarket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grdMarket.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._grdMarket.Location = new System.Drawing.Point(6, 19);
            this._grdMarket.Name = "_grdMarket";
            this._grdMarket.Size = new System.Drawing.Size(376, 275);
            this._grdMarket.TabIndex = 3;
            // 
            // _grpYou
            // 
            this._grpYou.Controls.Add(this.label8);
            this._grpYou.Controls.Add(this.label2);
            this._grpYou.Controls.Add(this._txtWithdrawAmount);
            this._grpYou.Controls.Add(this._txtDepositAmount);
            this._grpYou.Controls.Add(this._llLoanShark);
            this._grpYou.Controls.Add(this._lblLoan);
            this._grpYou.Controls.Add(this.label7);
            this._grpYou.Controls.Add(this._llBankWithdraw);
            this._grpYou.Controls.Add(this._llBankDeposit);
            this._grpYou.Controls.Add(this._lblBank);
            this._grpYou.Controls.Add(this.label4);
            this._grpYou.Controls.Add(this._llAddCapacity);
            this._grpYou.Controls.Add(this._lblRemainingCapacity);
            this._grpYou.Controls.Add(this.label6);
            this._grpYou.Controls.Add(this._lblMoney);
            this._grpYou.Controls.Add(this.label3);
            this._grpYou.Controls.Add(this._cmbSelectedCity);
            this._grpYou.Controls.Add(this._grdInventory);
            this._grpYou.Controls.Add(this.label1);
            this._grpYou.Location = new System.Drawing.Point(11, 97);
            this._grpYou.Name = "_grpYou";
            this._grpYou.Size = new System.Drawing.Size(351, 337);
            this._grpYou.TabIndex = 1;
            this._grpYou.TabStop = false;
            this._grpYou.Text = "You";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "[Space Bar]";
            // 
            // _txtWithdrawAmount
            // 
            this._txtWithdrawAmount.BackColor = System.Drawing.Color.Yellow;
            this._txtWithdrawAmount.Location = new System.Drawing.Point(215, 125);
            this._txtWithdrawAmount.Name = "_txtWithdrawAmount";
            this._txtWithdrawAmount.Size = new System.Drawing.Size(50, 20);
            this._txtWithdrawAmount.TabIndex = 18;
            // 
            // _txtDepositAmount
            // 
            this._txtDepositAmount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this._txtDepositAmount.Location = new System.Drawing.Point(215, 97);
            this._txtDepositAmount.Name = "_txtDepositAmount";
            this._txtDepositAmount.Size = new System.Drawing.Size(50, 20);
            this._txtDepositAmount.TabIndex = 14;
            // 
            // _llLoanShark
            // 
            this._llLoanShark.AutoSize = true;
            this._llLoanShark.Location = new System.Drawing.Point(271, 155);
            this._llLoanShark.Name = "_llLoanShark";
            this._llLoanShark.Size = new System.Drawing.Size(68, 13);
            this._llLoanShark.TabIndex = 17;
            this._llLoanShark.TabStop = true;
            this._llLoanShark.Text = "[L]oan Shark";
            this._llLoanShark.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._llLoanShark_LinkClicked);
            // 
            // _lblLoan
            // 
            this._lblLoan.AutoSize = true;
            this._lblLoan.Location = new System.Drawing.Point(135, 152);
            this._lblLoan.Name = "_lblLoan";
            this._lblLoan.Size = new System.Drawing.Size(13, 13);
            this._lblLoan.TabIndex = 16;
            this._lblLoan.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Loan";
            // 
            // _llBankWithdraw
            // 
            this._llBankWithdraw.AutoSize = true;
            this._llBankWithdraw.Location = new System.Drawing.Point(271, 132);
            this._llBankWithdraw.Name = "_llBankWithdraw";
            this._llBankWithdraw.Size = new System.Drawing.Size(58, 13);
            this._llBankWithdraw.TabIndex = 14;
            this._llBankWithdraw.TabStop = true;
            this._llBankWithdraw.Text = "[W]ithdraw";
            this._llBankWithdraw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._llBankWithdraw_LinkClicked);
            // 
            // _llBankDeposit
            // 
            this._llBankDeposit.AutoSize = true;
            this._llBankDeposit.Location = new System.Drawing.Point(271, 100);
            this._llBankDeposit.Name = "_llBankDeposit";
            this._llBankDeposit.Size = new System.Drawing.Size(49, 13);
            this._llBankDeposit.TabIndex = 12;
            this._llBankDeposit.TabStop = true;
            this._llBankDeposit.Text = "[D]eposit";
            this._llBankDeposit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._llBank_LinkClicked);
            // 
            // _lblBank
            // 
            this._lblBank.AutoSize = true;
            this._lblBank.Location = new System.Drawing.Point(135, 100);
            this._lblBank.Name = "_lblBank";
            this._lblBank.Size = new System.Drawing.Size(13, 13);
            this._lblBank.TabIndex = 11;
            this._lblBank.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bank";
            // 
            // _llAddCapacity
            // 
            this._llAddCapacity.AutoSize = true;
            this._llAddCapacity.Location = new System.Drawing.Point(271, 73);
            this._llAddCapacity.Name = "_llAddCapacity";
            this._llAddCapacity.Size = new System.Drawing.Size(75, 13);
            this._llAddCapacity.TabIndex = 9;
            this._llAddCapacity.TabStop = true;
            this._llAddCapacity.Text = "Buy [C]apacity";
            this._llAddCapacity.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._llAddCapacity_LinkClicked);
            // 
            // _lblRemainingCapacity
            // 
            this._lblRemainingCapacity.AutoSize = true;
            this._lblRemainingCapacity.Location = new System.Drawing.Point(135, 73);
            this._lblRemainingCapacity.Name = "_lblRemainingCapacity";
            this._lblRemainingCapacity.Size = new System.Drawing.Size(13, 13);
            this._lblRemainingCapacity.TabIndex = 8;
            this._lblRemainingCapacity.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Remaining Capacity";
            // 
            // _lblMoney
            // 
            this._lblMoney.AutoSize = true;
            this._lblMoney.Location = new System.Drawing.Point(135, 46);
            this._lblMoney.Name = "_lblMoney";
            this._lblMoney.Size = new System.Drawing.Size(13, 13);
            this._lblMoney.TabIndex = 5;
            this._lblMoney.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current City";
            // 
            // _cmbSelectedCity
            // 
            this._cmbSelectedCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbSelectedCity.FormattingEnabled = true;
            this._cmbSelectedCity.Location = new System.Drawing.Point(138, 13);
            this._cmbSelectedCity.Name = "_cmbSelectedCity";
            this._cmbSelectedCity.Size = new System.Drawing.Size(127, 21);
            this._cmbSelectedCity.TabIndex = 2;
            this._cmbSelectedCity.SelectedIndexChanged += new System.EventHandler(this._cmbSelectedCity_SelectedIndexChanged);
            // 
            // _grdInventory
            // 
            this._grdInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grdInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grdInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._grdInventory.Location = new System.Drawing.Point(6, 171);
            this._grdInventory.Name = "_grdInventory";
            this._grdInventory.Size = new System.Drawing.Size(336, 123);
            this._grdInventory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money";
            // 
            // _lblDaysLeft
            // 
            this._lblDaysLeft.AutoSize = true;
            this._lblDaysLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDaysLeft.Location = new System.Drawing.Point(147, 9);
            this._lblDaysLeft.Name = "_lblDaysLeft";
            this._lblDaysLeft.Size = new System.Drawing.Size(19, 20);
            this._lblDaysLeft.TabIndex = 8;
            this._lblDaysLeft.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Days Left";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(796, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _lblStatus
            // 
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(12, 17);
            this._lblStatus.Text = "_";
            // 
            // _llHighScores
            // 
            this._llHighScores.AutoSize = true;
            this._llHighScores.Location = new System.Drawing.Point(689, 29);
            this._llHighScores.Name = "_llHighScores";
            this._llHighScores.Size = new System.Drawing.Size(65, 13);
            this._llHighScores.TabIndex = 10;
            this._llHighScores.TabStop = true;
            this._llHighScores.Text = "High Scores";
            this._llHighScores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._llHighScores_LinkClicked);
            // 
            // _llNewGame
            // 
            this._llNewGame.AutoSize = true;
            this._llNewGame.Location = new System.Drawing.Point(694, 9);
            this._llNewGame.Name = "_llNewGame";
            this._llNewGame.Size = new System.Drawing.Size(60, 13);
            this._llNewGame.TabIndex = 11;
            this._llNewGame.TabStop = true;
            this._llNewGame.Text = "New Game";
            this._llNewGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._llNewGame_LinkClicked);
            // 
            // _lblGameStatus
            // 
            this._lblGameStatus.AutoSize = true;
            this._lblGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblGameStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this._lblGameStatus.Location = new System.Drawing.Point(5, 8);
            this._lblGameStatus.Name = "_lblGameStatus";
            this._lblGameStatus.Size = new System.Drawing.Size(51, 20);
            this._lblGameStatus.TabIndex = 12;
            this._lblGameStatus.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this._lblGameStatus);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 42);
            this.panel1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "[S] To Auto-Sell";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._llNewGame);
            this.Controls.Add(this._llHighScores);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._lblDaysLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._grpYou);
            this.Controls.Add(this._grpMarket);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gum Wars";
            this.Load += new System.EventHandler(this.Form1_Load);
            this._grpMarket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grdMarket)).EndInit();
            this._grpYou.ResumeLayout(false);
            this._grpYou.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grdInventory)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _grpMarket;
        private System.Windows.Forms.GroupBox _grpYou;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView _grdInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cmbSelectedCity;
        private System.Windows.Forms.Label _lblMoney;
        private System.Windows.Forms.Label _lblDaysLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView _grdMarket;
        private System.Windows.Forms.Label _lblRemainingCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _lblStatus;
        private System.Windows.Forms.LinkLabel _llAddCapacity;
        private System.Windows.Forms.LinkLabel _llHighScores;
        private System.Windows.Forms.LinkLabel _llNewGame;
        private System.Windows.Forms.LinkLabel _llBankDeposit;
        private System.Windows.Forms.Label _lblBank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblGameStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel _llBankWithdraw;
        private System.Windows.Forms.LinkLabel _llLoanShark;
        private System.Windows.Forms.Label _lblLoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtWithdrawAmount;
        private System.Windows.Forms.TextBox _txtDepositAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}

